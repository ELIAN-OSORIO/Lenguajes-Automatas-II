using Scanner.Views;
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
using System.Windows.Shapes;

namespace Scanner
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DataContext = new UserControl1();
            MainWindow ventana = new MainWindow();
            ventana.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //DataContext = new UserControl2();
            DataContext = new UserControl1();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //DataContext = new UserControl3();
            DataContext = new UserControl2();
        }

        private void ventanainfo(object sender, RoutedEventArgs e)
        {
            Page10 ventana = new Page10();
            ventanaInfo.Content = ventana;
        }

        private void ventanaprincipal(object sender, RoutedEventArgs e)
        {
            MainWindow ventana = new MainWindow();
            ventana.Show();
            Close();
        }

        private void ventanaconsulta(object sender, RoutedEventArgs e)
        {
            DataContext = new UserControl3();
        }


        //private void ventanapps(object sender, RoutedEventArgs e)
        //{
        //DataContext = new UserControl3();
        //}
    }
}
