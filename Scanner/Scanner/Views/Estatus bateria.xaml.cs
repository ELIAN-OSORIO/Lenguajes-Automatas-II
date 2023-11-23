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

namespace Scanner.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Ventana_usuario(object sender, RoutedEventArgs e)
        {
            Page4 ventana = new Page4();
            Frameprueba.Content = ventana;
        }

        private void Ventana_estatus(object sender, RoutedEventArgs e)
        {
            Page1 ventana = new Page1();
            Frameprueba.Content = ventana;
        }
    }
}
