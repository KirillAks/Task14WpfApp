using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductPrice = 40,
                ProductImage = "Data/хлеб.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                ProductPrice = 80,
                ProductImage = "Data/Молоко.png",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Кофемашина",
                ProductPrice = 50000,
                ProductImage = "Data/кофемашина.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                ProductPrice = 10000,
                ProductImage = "Data/микроволновка.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
