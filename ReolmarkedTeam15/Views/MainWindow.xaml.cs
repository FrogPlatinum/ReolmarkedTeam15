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

        public MainWindow()
        {
            InitializeComponent();

            IStallRepo stallRepo = new MemoryStallRepo();
            DataContext = new MainViewModel(stallRepo);

            MainFrame.Navigate(new FrontPageView()); //makes the program display FrontPageView on startup :)
        }

        private void ShowStallView_Click(object sender, RoutedEventArgs e) // Display "StallView" on click.
        {
            //Dunno hvad de her metoder er, er det andre views? Googlede frem til at sætte datacontext til dem, det virker nu. Amanda Note: De virkerede for mig uden det her :D
            var stallView = new StallView();
            stallView.DataContext = this.DataContext;
            
            MainFrame.Navigate(stallView);
        }

        private void ShowFrontPageView_Click(object sender, RoutedEventArgs e) // Display "FrontPageView" on click.
        {
            MainFrame.Navigate(new FrontPageView());
        }

        private void ShowRenterView_Click(object sender, RoutedEventArgs e) // Display "RenterView" on click.
        {
            //Dunno hvad de her metoder er, er det andre views? Googlede frem til at sætte datacontext til dem, det virker nu.
            var RenterView = new RenterView();
            RenterView.DataContext = this.DataContext;

            MainFrame.Navigate(RenterView);
        }
    } 
}