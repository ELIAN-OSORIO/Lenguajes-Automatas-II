using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
namespace Scanner.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection conexionDB = conexion.conex();
            try
            {
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionDB;
                comando.CommandText = "insert into produccion(id_matricula,name,apellido,fecha,pregunta1,pregunta2,pregunta3,pregunta4,pregunta5,pregunta6,pregunta7,pregunta8,pregunta9,pregunta10,pregunta11,pregunta12) values('" + txtID.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + fecha.Text + "','" + pregunta1.IsChecked + "','" + pregunta2.IsChecked + "','" + pregunta3.IsChecked + "','" + pregunta4.IsChecked + "','" + pregunta5.IsChecked + "','" + pregunta6.IsChecked + "','" + pregunta7.IsChecked + "','" + pregunta8.IsChecked + "','" + pregunta9.IsChecked + "','" + pregunta10.IsChecked + "','" + pregunta11.IsChecked + "','" + pregunta12.IsChecked + "')";
                comando.ExecuteNonQuery();
                conexionDB.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message+r.StackTrace);
                
            }
            MessageBox.Show("Datos ingresados correctamente");
            
        }

        private void pregunta1_Checked(object sender, RoutedEventArgs e)
        {
            if (pregunta1.IsChecked == true && casilla1.IsChecked ==false)
            {
                pregunta1.IsChecked = true;
            }
            else if(casilla1.IsChecked==true && pregunta1.IsChecked==false)
            {
                casilla1.IsChecked = false;
            }
        }

        private void pregunta2_Checked(object sender, RoutedEventArgs e)
        {
            if (pregunta2.IsChecked == true && casilla2.IsChecked ==false)
            {
                pregunta2.IsChecked = true;
            }
            else if(casilla2.IsChecked==true && pregunta2.IsChecked==false)
            {
                casilla2.IsChecked = false;
            }
        }

        private void p3(object sender, RoutedEventArgs e)
        {
            if (pregunta3.IsChecked == true && casilla3.IsChecked==false)
            {
                pregunta3.IsChecked = true;
            }
            else if(casilla3.IsChecked==true && pregunta3.IsChecked==false)
            {
                casilla3.IsChecked = false;
            }
        }

        private void p4(object sender, RoutedEventArgs e)
        {
            if (pregunta4.IsChecked == true && casilla4.IsChecked==false)
            {
                pregunta4.IsChecked = true;
            }
            else if(casilla4.IsChecked==true && pregunta4.IsChecked==false)
            {
                casilla4.IsChecked = false;
            }
        }

        private void p5(object sender, RoutedEventArgs e)
        {
            if (pregunta5.IsChecked == true && casilla5.IsChecked==false)
            {
                pregunta5.IsChecked = true;
            }
            else if(casilla5.IsChecked==true && pregunta5.IsChecked==false)
            {
                casilla5.IsChecked = false;
            }
        }

        private void p6(object sender, RoutedEventArgs e)
        {
            if (pregunta6.IsChecked == true && casilla6.IsChecked==false)
            {
                pregunta6.IsChecked = true;
            }
            else if(casilla6.IsChecked==true && pregunta6.IsChecked==false)
            {
                casilla6.IsChecked = false;
            }
        }

        private void p7(object sender, RoutedEventArgs e)
        {
            if (pregunta7.IsChecked == true && casilla7.IsChecked==false)
            {
                pregunta7.IsChecked = true;
            }
            else if(casilla7.IsChecked==true && pregunta7.IsChecked==false)
            {
                casilla7.IsChecked = false;
            }
        }

        private void p8(object sender, RoutedEventArgs e)
        {
            if (pregunta8.IsChecked == true && casilla8.IsChecked==false)
            {
                pregunta8.IsChecked = true;
            }
            else if(casilla8.IsChecked==true && pregunta8.IsChecked==false)
            {
                casilla8.IsChecked = false;
            }
        }

        private void p9(object sender, RoutedEventArgs e)
        {
            if (pregunta9.IsChecked == true && casilla9.IsChecked==false)
            {
                pregunta9.IsChecked = true;
            }
            else if(casilla9.IsChecked==true && pregunta9.IsChecked==false)
            {
                casilla9.IsChecked = false;
            }
        }

        private void p10(object sender, RoutedEventArgs e)
        {
            if (pregunta10.IsChecked == true && casilla10.IsChecked==false)
            {
                pregunta10.IsChecked = true;
            }
            else if(casilla10.IsChecked==true && pregunta10.IsChecked==false)
            {
                casilla10.IsChecked = false;
            }
        }

        private void p11(object sender, RoutedEventArgs e)
        {
            if (pregunta11.IsChecked == true && casilla11.IsChecked==false)
            {
                pregunta11.IsChecked = true;
            }
            else if(casilla11.IsChecked==true && pregunta11.IsChecked==false)
            {
                casilla11.IsChecked = false;
            }
        }

        private void p12(object sender, RoutedEventArgs e)
        {
            if (pregunta12.IsChecked == true && casilla12.IsChecked==false)
            {
                pregunta12.IsChecked = true;
            }
            else if(casilla12.IsChecked==true && pregunta12.IsChecked==false)
            {
                casilla12.IsChecked = false;
            }
        }

        private void txtID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            
            if(!regex.IsMatch(e.Text))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros.", "Validacion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void txtApellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z ]+$");

            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Validacion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z ]+$");

            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Validacion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
