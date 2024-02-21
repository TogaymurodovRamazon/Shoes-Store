using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shoes_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var product = GerProducts();
            if(product.Count > 0)
               ListViewProducts.ItemsSource = product;
        }

        private List<Product> GerProducts()
        {
            return new List<Product>()
            {
                new Product("Product 1", 70.35, "1.jfif"),
                new Product("Product 2", 40.50, "2.jfif"),
                new Product("Product 3", 50.55, "3.jfif"),
                new Product("Product 4", 30.35, "4.jfif"),
                new Product("Product 5", 50.55, "5.jfif"),
                new Product("Product 6", 40.00, "6.jfif"),
                new Product("Product 7", 60.85, "7.jfif"),
                new Product("Product 8", 80.50, "8.jpg")
            };
        }
    }
}