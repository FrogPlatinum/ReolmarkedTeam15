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
using System.Windows.Shapes;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.ViewModels;
using ReolmarkedTeam15.Repos;


namespace ReolmarkedTeam15.Views
{
    /// <summary>
    /// Interaction logic for AddRenter.xaml
    /// </summary>
    public partial class AddRenterView : Window
    {
        //private IRenterRepo _renterRepo;

        public AddRenterView()
        {
           InitializeComponent();
           //_renterRepo = renterRepo;

            
           //DataContext = new RenterViewModel(_renterRepo);


        }

    }
}
