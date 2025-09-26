using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReolmarkedTeam15.Helpers;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        //Instances of sub viewmodels
        public StallViewModel StallVM { get; }
        public RenterViewModel RenterVM { get; }

        public MainViewModel(IStallRepo stallRepo, IRenterRepo renterRepo)
        {
            StallVM = new StallViewModel(stallRepo);
            RenterVM = new RenterViewModel(renterRepo);

            UpdateRenterStallCount();
            DisplayStallRenter();
        }
        //Counting renters number of stalls
        public void UpdateRenterStallCount()
        {
            foreach (var r in RenterVM.Renters)
            {
                r.NumberOfStallsRented = StallVM.Stalls.Count(o => o.RenterID == r.RenterID);
            }
        }
        //Checking stalls and renters for matching renter id and displaying owner first and last name
        public void DisplayStallRenter()
        {
            foreach(var o in StallVM.Stalls)
            {
                //Skal sørge for at IDs er >0 da NULL ikke virker
                if (o.RenterID != 0)
                {
                    var renter = RenterVM.Renters.FirstOrDefault(r => r.RenterID == o.RenterID);
                    if (renter != null)
                    {
                        o.StallRenter = $"{renter.RenterFirstName} {renter.RenterLastName}";
                    }
                    else
                    {
                        o.StallRenter = "Ukendt";
                    }
                }
                //Optional : Can replace "Udlejnings status" with this 
                //else
                //{
                //    o.StallRenter = "Ledig";
                //}
            }
        }

        //Metode til at assigne en renter til en stall.
      


        ////PropertyChangedHandler - Commented out since it's in BaseViewModel now.
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged
        //([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke
        //    (this, new PropertyChangedEventArgs(name));
        //}
    }
}
