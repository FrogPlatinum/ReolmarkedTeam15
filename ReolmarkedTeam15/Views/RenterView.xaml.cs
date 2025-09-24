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
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.ViewModels;
using ReolmarkedTeam15.Views;

namespace ReolmarkedTeam15.Views
{
    /// <summary>
    /// Interaction logic for RenterView.xaml
    /// </summary>
    public partial class RenterView : Page
    {
       
        public RenterView()
        {
            InitializeComponent();

        
        }

        private void AddRenter_Click(object sender, RoutedEventArgs e)
        {
            AddRenterView AddRenterWindow = new AddRenterView();
            AddRenterWindow.DataContext = this.DataContext;
            AddRenterWindow.Show();
        }
    }
}
