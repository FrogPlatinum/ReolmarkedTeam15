using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Repos;
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
using System.Windows.Shapes;

namespace ReolmarkedTeam15.Views
{
    /// <summary>
    /// Interaction logic for RentStallView.xaml
    /// </summary>
    public partial class RentStallView : Window
    {
       // public ObservableCollection<Renter> Renters { get; set; }
        //public Renter SelectedRenter { get; set; }
        //private Stall _stallToRent;

        public RentStallView(Stall stallToRent)
        {
            InitializeComponent();

            //var renterRepo = new MemoryRenterRepo(); // New instance of renter repository -> Shared repo??
            //Renters = new ObservableCollection<Renter>(renterRepo.GetAll());

            //_stallToRent = stallToRent;
            DataContext = this;
        }
        // Assign renter to stall and change availability status
        private void RentOutButton_Click(object sender, RoutedEventArgs e)
        {
            //_stallToRent.RenterID = SelectedRenter.RenterID;
            //_stallToRent.Availability = Stall.AvailabilityStatus.Optaget;

            //MessageBox.Show($"Reol {_stallToRent.StallID} udlejet til {SelectedRenter.RenterFirstName} {SelectedRenter.RenterLastName}!");
            //this.Close();
        }
    }
}
