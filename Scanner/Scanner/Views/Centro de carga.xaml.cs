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
    /// Lógica de interacción para Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Next_Page(object sender, RoutedEventArgs e)
        {
            Page7 ventana = new Page7();
            Pagina7.Content = ventana;
        }

        private void Back_Page(object sender, RoutedEventArgs e)
        {
            Page5 ventana = new Page5();
            Pagina7.Content = ventana;
        }
    }
}
