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
    public class StallViewModel : BaseViewModel
    {
        //Repo
        private IStallRepo _stallRepo;

        //List for View
        public ObservableCollection<Stall> Stalls { get; }

        //Properties
        //Stuff for "Udlej Reol" button
        //Bool to enable/disable Button
        private bool _isStallSelected;
        public bool IsStallSelected
        {
            get => _isStallSelected;
            set
            {
                _isStallSelected = value;
                OnPropertyChanged();
            }
        }
        //Checking datagrid if item is selected
        private Stall _selectedStall;
        public Stall SelectedStall
        {
            get => _selectedStall;
            set
            {
                _selectedStall = value;
                OnPropertyChanged();
                //If else for IsStallSelected
                if (_selectedStall != null && _selectedStall.Availability == Stall.AvailabilityStatus.Ledig)
                {
                    IsStallSelected = true;
                }
                else
                {
                    IsStallSelected = false;
                }
            }
        }

        public StallViewModel(IStallRepo stallRepo)
        {
            _stallRepo = stallRepo;
            Stalls = new ObservableCollection<Stall>(_stallRepo.GetAll());
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
