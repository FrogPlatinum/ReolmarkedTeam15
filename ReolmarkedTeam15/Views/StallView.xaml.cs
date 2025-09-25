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
            if (DataContext is ReolmarkedTeam15.ViewModels.StallViewModel vm) // To access StallViewModel: selectedStall
            {
                var selectedStall = vm.SelectedStall; // Selected stall from DataGrid
                var rentStallWindow = new RentStallView(selectedStall);
                rentStallWindow.Show();
            }
            else
            {
                throw new InvalidOperationException("DataContext is not of type StallViewModel");
            }
            //RentStallView RentStallWindow = new RentStallView();
            //RentStallWindow.Show();
        }
    }
}
