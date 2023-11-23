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
    /// Lógica de interacción para Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Back_Page(object sender, RoutedEventArgs e)
        {
            Page6 ventana = new Page6();
            Pagina8.Content = ventana;
        }

        private void Next_Page(object sender, RoutedEventArgs e)
        {
            Page8 ventana = new Page8();
            Pagina8.Content = ventana;
        }
    }
}
