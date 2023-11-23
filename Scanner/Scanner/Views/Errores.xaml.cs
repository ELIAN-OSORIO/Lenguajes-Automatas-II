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
    /// Lógica de interacción para Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();
        }

        private void Back_page(object sender, RoutedEventArgs e)
        {
            Page8 ventana = new Page8();
            back.Content = ventana;
        }

        private void Ventana_final(object sender, RoutedEventArgs e)
        {
            Page11 ventana = new Page11();
            back.Content = ventana;
         }
    }
}
