using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.Interfaces
{
    public interface IStallRepo
    {
        public void Add(Stall stall);
        public IEnumerable<Stall> GetAll();
        public Stall GetById(int id);
        public void Update(Stall stall);
        public void Delete(Stall stall);
    }
}
