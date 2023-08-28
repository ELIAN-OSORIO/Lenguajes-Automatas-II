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
    /// Lógica de interacción para Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        public Page8()
        {
            InitializeComponent();
        }

        private void page7(object sender, RoutedEventArgs e)
        {
            Page7 ventana = new Page7();
            back.Content = ventana;
        }

        private void ventana9(object sender, RoutedEventArgs e)
        {
            Page9 ventana = new Page9();
            back.Content = ventana;
        }
    }
}
