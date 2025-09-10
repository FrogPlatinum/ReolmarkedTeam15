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
using ReolmarkedTeam15.ViewModels;

namespace ReolmarkedTeam15.Views
{
    /// <summary>
    /// Denne side bruges primært til vores navigation bar.
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            MainFrame.Navigate(new FrontPageView()); //makes the program display FrontPageView on startup :)
        }

        private void ShowStallView_Click(object sender, RoutedEventArgs e) // Display "StallView" on click.
        {
           
            MainFrame.Navigate(new StallView());
        }

        private void FrontPageView_Click(object sender, RoutedEventArgs e) // Display "FrontPageView" on click.
        {
            MainFrame.Navigate(new FrontPageView());
        }
    } 
}