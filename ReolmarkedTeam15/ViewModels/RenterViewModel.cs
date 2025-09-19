using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.ViewModels
{
    public class RenterViewModel
    {
        private IRenterRepo _renterRepo;

        public ObservableCollection<Renter> Renters { get; }

        public RenterViewModel(IRenterRepo renterRepo)
        {
            _renterRepo = renterRepo;
            Renters = new ObservableCollection<Renter>(_renterRepo.GetAll());
        }
    }
}
