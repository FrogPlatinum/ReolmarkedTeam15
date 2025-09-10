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
        //Repo for data access
        private IStallRepo _stallRepo;

        //List for WPF
        public ObservableCollection<Stall> Stalls { get; set; }

        public MainViewModel(IStallRepo stallRepo)
        {
            //Injecting repo from mainwindow to here
            _stallRepo = stallRepo;

            //Getting list from data access repo and putting it into WPF list
            Stalls = new ObservableCollection<Stall>(_stallRepo.GetAll());
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
