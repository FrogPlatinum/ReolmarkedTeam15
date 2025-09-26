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
using ReolmarkedTeam15.ViewModels;


namespace ReolmarkedTeam15.Views
{
    /// <summary>
    /// Interaction logic for StallView.xaml
    /// </summary>
    public partial class StallView : Page
    {
        public StallView()
        {
            InitializeComponent();
            
        }

        private void RentOutStall_Click(object sender, RoutedEventArgs e)
        {
            var mainVm = this.DataContext as MainViewModel;
            var selectedStall = mainVm.StallVM.SelectedStall;
            var rentStallWindow = new RentStallView(selectedStall);
            rentStallWindow.DataContext = this.DataContext;
            rentStallWindow.Show();

            
            //
            //RentStallView RentStallWindow = new RentStallView();
            //RentStallWindow.Show();

            //AddRenterView AddRenterWindow = new AddRenterView();
            //AddRenterWindow.DataContext = this.DataContext;
            //AddRenterWindow.Show();
        }
    }
}
