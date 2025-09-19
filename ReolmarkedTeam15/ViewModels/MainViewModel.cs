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
        public StallViewModel StallViewM { get; }

        public MainViewModel(IStallRepo stallRepo)
        {
            StallViewM = new StallViewModel(stallRepo);
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
