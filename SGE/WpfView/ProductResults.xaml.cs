using Controller;
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

namespace WpfView
{
    /// <summary>
    /// Lógica interna para ProductResults.xaml
    /// </summary>
    public partial class ProductResults : Window
    {
        public ProductResults()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowtableProductsResults(txtInputSearch);
        }

        public void ShowtableProductsResults(string prodSearch)
        {
            tableProductsResults.ItemsSource = ListByName(prodSearch);
            
        }
    }
}
