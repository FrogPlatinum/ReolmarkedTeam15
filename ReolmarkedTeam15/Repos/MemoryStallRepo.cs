using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.Repos
{
    public class MemoryStallRepo : IStallRepo
    {
        //Memory list for Stalls
        private List<Stall> _stallList = new List<Stall>();
        
        //Constructor with sample data
        public MemoryStallRepo() 
        {
            Stall sampleStall1 = new Stall(10,Stall.AvailabilityStatus.Ledig,Stall.StallTypes.A,20);
            _stallList.Add(sampleStall1);

            Stall sampleStall2 = new Stall(20, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.B, 30);
            _stallList.Add(sampleStall2);

            Stall sampleStall3 = new Stall(30, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 40);
            _stallList.Add(sampleStall3);
        }

        //Add
        public void Add(Stall stall)
        {
            _stallList.Add(stall);
        }

        //Delete
        public void Delete(Stall stall)
        {
            _stallList.Remove(stall);
        }

        //Get All
        public IEnumerable<Stall> GetAll()
        {
            return _stallList;
        }

        //Get By ID
        public Stall GetById(int id)
        {
            foreach (Stall stall in _stallList)
            {
                if(id == stall.StallID)
                {
                    return stall;
                }    
            }
            return null;
        }

        //Update
        public void Update(Stall stall)
        {
            Stall stallToEdit = stall;

            foreach(Stall stall1 in _stallList)
            {
                if(stallToEdit.StallID == stall.StallID)
                {
                    stall.Availability = stallToEdit.Availability;
                    stall.StallType = stallToEdit.StallType;
                    stall.Location = stallToEdit.Location;
                }
            }
        }
    }
}
