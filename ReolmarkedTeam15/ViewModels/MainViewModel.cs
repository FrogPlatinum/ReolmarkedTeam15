using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Helpers;

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
        }
        public void UpdateRenterStallCount()
        {
            foreach (var r in RenterVM.Renters)
            {
                r.NumberOfStallsRented = StallVM.Stalls.Count(o => o.RenterID == r.RenterID);
            }
        }
        // ---- Continue Here
        public void DisplayStallRenter()
        {
            foreach(var o in StallVM.Stalls)
            {
                if(o.RenterID != null)
                {
                    var renter = RenterVM.Renters.FirstOrDefault(r => r.RenterID == o.RenterID);
                }
            }
        }

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
