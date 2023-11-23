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
    /// Lógica de interacción para Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Next_Page(object sender, RoutedEventArgs e)
        {
            Page5 ventana = new Page5();
            Pagina5.Content = ventana;
        }

        private void Back_Page(object sender, RoutedEventArgs e)
        {
            UserControl1 ventana = new UserControl1();
            Pagina5.Content = ventana;
        }
    }
}
