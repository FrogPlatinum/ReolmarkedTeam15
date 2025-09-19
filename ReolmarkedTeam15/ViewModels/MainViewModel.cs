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

namespace ReolmarkedTeam15.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public StallViewModel StallVM { get; }
        public RenterViewModel RenterVM { get; }

        public MainViewModel(IStallRepo stallRepo, IRenterRepo renterRepo)
        {
            StallVM = new StallViewModel(stallRepo);
            RenterVM = new RenterViewModel(renterRepo);
        }





        //PropertyChangedHandler
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged
        ([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke
            (this, new PropertyChangedEventArgs(name));
        }
    }
}
