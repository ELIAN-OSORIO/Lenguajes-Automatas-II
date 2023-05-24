""" flask project"""
from flask import Flask, request, jsonify, make_response, render_template
from flask_sqlalchemy import SQLAlchemy
import uuid
from werkzeug.security import generate_password_hash, check_password_hash
import jwt
from datetime import datetime, timedelta
from functools import wraps

app = Flask(__name__)

app.config['SECRET_KEY'] = 'fe5aa54dbe744c069927a3e0df05917d'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///Database.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True
db = SQLAlchemy(app)

class User(db.Model):
    """Database"""
    id = db.Column(db.Integer, primary_key = True)
    public_id = db.Column(db.String(50), unique = True)
    name = db.Column(db.String(100))
    lastname = db.Column(db.String(100))
    email = db.Column(db.String(70), unique = True)
    password = db.Column(db.String(80))

#with app.app_context():
   #db.create_all()

def token_required(f):
    """Token_access"""
    @wraps(f)
    def decorated(*args, **kwargs):
        token = None
        if 'x-access-token' in request.headers:
            token = request.headers['x-access-token']
        if not token:
            return jsonify({'message' : 'Token is missing !!'}), 401
        try:
            data = jwt.decode(token, app.config['SECRET_KEY'])
            current_user = User.query\
                .filter_by(public_id = data['public_id'])\
                .first()
        except:
            return jsonify({
                'message' : 'Token is invalid !!'
            }), 401
        return f(current_user, *args, **kwargs)
    return decorated

@app.route('/user', methods =['GET'])
@token_required
def get_all_users(current_user):
    """Token"""
    users = User.query.all()
    output = []
    for user in users:
        output.append({
            'public_id': user.public_id,
            'name': user.name,
            'lastname': user.lastname,
            'email': user.email
        })
    return jsonify({'users': output})

@app.route("/")
def index():
    return render_template("index.html")

@app.route('/login', methods =['POST'])
def login():
    """Login"""
    auth = request.form
    if not auth or not auth.get('email') or not auth.get('password'):
        return make_response(
            'Could not verify',
            401,
            {'WWW-Authenticate' : 'Basic realm ="Login required !!"'}
        )      
    user = User.query\
        .filter_by(email = auth.get('email'))\
        .first()  
    if not user:
        return make_response(
            'Could not verify',
            401,
            {'WWW-Authenticate' : 'Basic realm ="User does not exist !!"'}
        )
    if check_password_hash(user.password, auth.get('password')):
        token = jwt.encode({
            'public_id': user.public_id,
            'exp': datetime.utcnow() + timedelta(minutes=30)
        }, app.config['SECRET_KEY'])

        return make_response(jsonify({'token': token.decode('UTF-8')}), 201)
    return make_response(
        'Could not verify',
        403,
        {'WWW-Authenticate' : 'Basic realm ="Wrong Password !!"'}
    )

@app.route('/signup', methods =['POST'])
def signup():
    """Sigup Usuario"""
    data = request.form

    name, lastname, email = data.get('name'), data.get('lastname'), data.get('email')
    password = data.get('password')

    user = User.query\
        .filter_by(email = email)\
        .first()
    if not user:
        user = User(
            public_id = str(uuid.uuid4()),
            name = name,
            lastname = lastname,
            email = email,
            password = generate_password_hash(password)
        )
        db.session.add(user)
        db.session.commit()

        return make_response('Successfully registered.', 201)
    else:
        return make_response('User already exists. Please Log in.', 202 )   
if __name__ == "__main__":     
    app.run(debug=True)
