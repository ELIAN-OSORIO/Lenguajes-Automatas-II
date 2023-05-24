"""Server"""
from flask import Flask, jsonify
import funciones


app = Flask(__name__)


@app.route('/file_pages')
def funcion_1():
    """Funcion que regresa cuantas hojas hay en el archivo"""
    return jsonify(funciones.file())


@app.route('/cell/<path:files>/<int:hoja>/<int:row>/<int:col>')
def funcion_3_cell(files, hoja, row, col):
    """Funcion que regresa el contenido de una celda en una hoja especifica"""
    return jsonify(funciones.cell(files, hoja, row, col))


@app.route('/matrix/<path:files>/<int:hoja>')
def funcion_7_matrix(files, hoja):
    """Funcion que me regresa toda la hoja en una matriz ordenada"""
    return jsonify(funciones.matrix(files, hoja))


@app.route('/row_col/<path:files>/<int:hoja>/<int:rows>/<int:col>')
def funcion_2_row_cols(files, hoja, rows, col):
    """Funcion que regresa cuantos renglones y columnas tiene una hoja"""
    return jsonify(funciones.row_col(files, hoja, rows, col))


@app.route('/cols/<path:files>/<int:hoja>/<int:col>')
def funcion_4_cols(files, hoja, col):
    """Funcion que regresa el contenido de una columna completa"""
    return jsonify(funciones.columns(files, hoja, col))


@app.route('/excel/columna1')
def columna():
    return "columna 1 data"

@app.route('/funciones')
def prueba():
    return(funciones.saludo())

@app.route('/')
def hello():
    return 'Hello, World!'

if __name__ == '__main__':
    print("main saludo")
    app.run()
