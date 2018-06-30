﻿using Controller;
using Model;
using System;
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
        }

    }
}
