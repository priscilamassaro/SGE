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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tableProducts.Items.Refresh();
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
            MessageBox.Show("Produto excluido com sucesso!");
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            tableProducts.Items.Refresh();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            tableProducts.Items.Refresh();
        }
    }
}
