using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.Interfaces
{
    public interface IRenterRepo
    {
        public void AddRenter(Renter renter);
        public IEnumerable<Renter> GetAll();
        public Renter GetById(int id);
        public void UpdateRenter(Renter renter);
        public void DeleteRenter(Renter renter);
    }
}
