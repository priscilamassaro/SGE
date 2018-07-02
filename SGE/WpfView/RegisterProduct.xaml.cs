using Controller;
using Model;
using System;
using System.Windows;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para RegisterProduct.xaml
    /// </summary>
    public partial class RegisterProduct : Window
    {
        public RegisterProduct()
        {
            InitializeComponent();
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
                prod.CategoryID = ((Category)SelectCategory.SelectedItem).CategoryID;
                prod.TypeOfSkinID = ((TypeOfSkin)SelectTypeOfSkin.SelectedItem).TypeOfSkinID;

                productController.AddProduct(prod);
                MessageBox.Show("Produto salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar (" + ex.Message + ")!");
            }
        }
        
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            CategoriesController categoriesController = new CategoriesController();

            SelectCategory.ItemsSource = categoriesController.ListAll();

            //SubCategoriesController subCategoriesController = new SubCategoriesController();

            //SelectSubCategory.ItemsSource = subCategoriesController.ListAll();

            TypeOfSkinController typeOfSkinController = new TypeOfSkinController();

            SelectTypeOfSkin.ItemsSource = typeOfSkinController.ListAll();
        }
    }
}
