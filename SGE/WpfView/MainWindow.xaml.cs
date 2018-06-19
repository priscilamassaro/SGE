using Controller;
using Model;
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

namespace WpfView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void BtnRegisterProduct_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ProductController productController = new ProductController();

                Product prod = new Product();
                prod.Name = TxtName.Text;
                prod.Price = double.Parse(TxtPrice.Text);
                prod.Quantity = int.Parse(TxtQuantity.Text);
                
                productController.AddProduct(prod);
                MessageBox.Show("Produto salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")!");
            }

        }
    }
}
