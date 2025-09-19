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
    public class StallViewModel
    {
        private IStallRepo _stallRepo;

        public ObservableCollection<Stall> Stalls { get; }

        public StallViewModel(IStallRepo stallRepo)
        {
            _stallRepo = stallRepo;
            Stalls = new ObservableCollection<Stall>(_stallRepo.GetAll());
        }
    }
}
