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
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Repos;
using ReolmarkedTeam15.ViewModels;

namespace ReolmarkedTeam15.Views
{
    /// <summary>
    /// Denne side bruges primært til vores navigation bar.
    /// </summary>
    public partial class MainWindow : Window
    {
        //Field to keep repo instant the same across pages
        private IStallRepo _stallRepo;
        private IRenterRepo _renterRepo;
        private IProductRepo _productRepo;
        private IOrderRepo _orderRepo;

        public MainWindow()
        {
            InitializeComponent();

            //Repo creation, currently set to MemoryRepos
            _stallRepo = new MemoryStallRepo();
            _renterRepo = new MemoryRenterRepo();
            _productRepo = new MemoryProductRepo();
            _orderRepo = new MemoryOrderRepo();

            //Passing repo to MainViewModel
            DataContext = new MainViewModel(_stallRepo, _renterRepo, _productRepo, _orderRepo);

            MainFrame.Navigate(new FrontPageView()); //makes the program display FrontPageView on startup :)
        }

        private void ShowStallView_Click(object sender, RoutedEventArgs e) // Display "StallView" on click.
        {
            
            var stallView = new StallView();
            
            //Stall view context set to StallViewModel
            stallView.DataContext = new StallViewModel(_stallRepo);
            
            MainFrame.Navigate(stallView);
        }

        private void ShowFrontPageView_Click(object sender, RoutedEventArgs e) // Display "FrontPageView" on click.
        {
            MainFrame.Navigate(new FrontPageView());
        }

        public void ShowRenterView_Click(object sender, RoutedEventArgs e) // Display "RenterView" on click.
        {
            var RenterView = new RenterView();

            //Renter view context set to RenterViewModel
            RenterView.DataContext = new RenterViewModel(_renterRepo);

            MainFrame.Navigate(RenterView);
        }

        private void ShowOrderView_Click(object sender, RoutedEventArgs e)
        {
            var OrderView = new OrderView();

            //Order view context set to OrderViewModel
            OrderView.DataContext = ((MainViewModel)DataContext).OrderVM;

            MainFrame.Navigate(OrderView);
        }

        private void ShowProductView_Click(object sender, RoutedEventArgs e)
        {
            var ProductView = new ProductView();

            //Product view context set to ProductViewModel
            ProductView.DataContext = new ProductViewModel(_productRepo, _stallRepo);

            MainFrame.Navigate(ProductView);
        }
    } 
}