﻿using SemesterProject_WPF_DB.Classes;
using System;
using System.Collections;
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

namespace SemesterProject_WPF_DB
{
    /// <summary>
    /// Interaction logic for productManager.xaml
    /// </summary>
    public partial class productManager : Window
    {
        ProductService ProductService = new ProductService();
        public productManager()
        {
            InitializeComponent();
            this.productDataGrid.ItemsSource = ProductService.GetList();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AdjustColumnOrder();
        }
        private void button_productUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (product_NameTextBox2.Text != "" && product_CategoryTextBox2.Text != "" && product_ManufacturerTextBox2.Text != "" && product_PriceTextBox2.Text != "" && product_CostTextBox2.Text != "")
            {
                var prdct = ProductService.SelectProductById(productID);

                decimal priceDecimal;
                bool priceResult = decimal.TryParse(product_PriceTextBox2.Text, out priceDecimal);
                if (!priceResult)
                {
                    MessageBox.Show("Price must be number");
                    return;
                }
                decimal costDecimal;
                bool costResult = decimal.TryParse(product_CostTextBox2.Text, out costDecimal);
                if (!costResult)
                {
                    MessageBox.Show("Cost must be number");
                    return;
                }
                if (priceDecimal < 0)
                {
                    MessageBox.Show("Price can not be less than 0.");
                    return;
                }
                if (costDecimal < 0)
                {
                    MessageBox.Show("Cost can not be less than 0.");
                    return;
                }
                ProductService.UpdateProduct(prdct, priceDecimal, costDecimal,product_CategoryTextBox2.Text,product_ManufacturerTextBox2.Text,product_NameTextBox2.Text);
                ReloadList();
            }
            else MessageBox.Show("All fields must be filled");
        }
        private void button_productDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var prdct = ProductService.SelectProductById(productID);
                ProductService.DeleteProduct(prdct);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Can not remove product that is signed to order");
            }
            clearTextBox();
            ReloadList();
        }
        private void AdjustColumnOrder()
        {
            this.productDataGrid.Columns[6].Visibility = Visibility.Collapsed;
            int x = 0;
            if (x == 0)
            {
                productDataGrid.Columns[0].Width = 30;  //index
                productDataGrid.Columns[1].Width = 90;  //Manufacturer
                productDataGrid.Columns[2].Width = 120; //model name 
                productDataGrid.Columns[3].Width = 120; //category
                productDataGrid.Columns[4].Width = 100; //Price
                productDataGrid.Columns[5].Width = 100; //Cost
                x++;
            }
            productDataGrid.Columns[0].DisplayIndex = 0; //index
            productDataGrid.Columns[1].DisplayIndex = 3; //Manufacturer
            productDataGrid.Columns[2].DisplayIndex = 2; //model name 
            productDataGrid.Columns[3].DisplayIndex = 1; //category
            productDataGrid.Columns[4].DisplayIndex = 4; //Price
            productDataGrid.Columns[0].Header = "ID";
            productDataGrid.Columns[1].Header = "Manufacturer";
            productDataGrid.Columns[2].Header = "Model Name";
            productDataGrid.Columns[3].Header = "Category";
            productDataGrid.Columns[4].Header = "Price";
            productDataGrid.Columns[5].Header = "Cost";

        }
        private int productID = 0;
        private void productGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            product p = this.productDataGrid.SelectedItem as product;
            if (p is null)
            {
                this.product_ManufacturerTextBox2.Text = string.Empty;
                this.product_NameTextBox2.Text = string.Empty;
                this.product_CategoryTextBox2.Text = string.Empty;
                this.product_PriceTextBox2.Text = string.Empty.ToString();
                this.product_CostTextBox2.Text = string.Empty.ToString();
                return;
            }
            this.product_ManufacturerTextBox2.Text = p.product_manufacturer_name;
            this.product_NameTextBox2.Text = p.product_name;
            this.product_CategoryTextBox2.Text = p.product_category_name;
            this.product_PriceTextBox2.Text = p.product_price.ToString();
            this.product_CostTextBox2.Text = p.product_cost.ToString();
            this.productID = p.product_id;
        }
        
        private void clearTextBox()
        {
            this.product_ManufacturerTextBox2.Text = string.Empty;
            this.product_NameTextBox2.Text = string.Empty;
            this.product_CategoryTextBox2.Text = string.Empty;
            this.product_PriceTextBox2.Text = string.Empty.ToString();
            this.product_CostTextBox2.Text = string.Empty.ToString();
        }
        private void button_productReload_Click(object sender, RoutedEventArgs e)
        {
            ReloadList();
        }
        private void button_closeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ReloadList()
        {
            this.productDataGrid.ItemsSource = ProductService.GetList();
            AdjustColumnOrder();
        }
    }
}