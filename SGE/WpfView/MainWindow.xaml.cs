using Controller;
using Model;
using System.Windows;

namespace WpfView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRegisterProduct_Click(object sender, RoutedEventArgs e)
        {
            RegisterProduct addProd = new RegisterProduct();
            addProd.ShowDialog();
            ShowtableProducts();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {           
            ShowtableProducts();
        }

        private void ShowtableProducts()
        {
            ProductController prodC = new ProductController();
            tableProducts.ItemsSource = prodC.ListAll();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int prod = ((Product)tableProducts.SelectedItem).ProductID;

            ProductController prodC = new ProductController();
            prodC.Delete(prod);
            MessageBox.Show("O produto foi excluído!");
            ShowtableProducts();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            ShowtableProducts();
        }      
    }
}
