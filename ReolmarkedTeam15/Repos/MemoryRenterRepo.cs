using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Interfaces;

namespace ReolmarkedTeam15.Repos
{
    public class MemoryRenterRepo : IRenterRepo
    {
        //Memory list for Renters
        private List<Renter> _renterList = new List<Renter>();
        public MemoryRenterRepo()
        {
        //Sample data
        Renter sampleRenter1 = new Renter(1111, "Hans", "Hansen", "12345678", "sample@example.com", 1);
        _renterList.Add(sampleRenter1);

        Renter sampleRenter2 = new Renter(2222, "Hans", "Jensen", "12345679", "sample@example.com", 3);


        _renterList.Add(sampleRenter2);
        }
        //Add
        public void AddRenter(Renter renter)
        {
            //Validate renter
            if (renter == null)
            {
                throw new ArgumentNullException(nameof(renter), "Null renter not allowed.");
            }
            
            _renterList.Add(renter);
        }
        //Delete
        public void DeleteRenter(Renter renter)
        {
            //Validate renter
            if (renter == null)
            {
                throw new ArgumentNullException(nameof(renter), "Null renter not allowed.");
            }
            _renterList.Remove(renter);
        }

        //Delete renter by id (Not in interface, but could be useful)
        /* 
        public void DeleteRenterById(int id)
        {
            var renterToDelete = GetById(id);
            if (renterToDelete != null)
            {
                _renterList.Remove(renterToDelete);
            }
            else
            {
                throw new ArgumentException("Renter with the specified ID does not exist.", nameof(id));
            }
        }
        */

        //GetAll
        public IEnumerable<Renter> GetAll()
        {
            return _renterList;
        }
        //GetById
        public Renter GetById(int id)
        {
            foreach (Renter renter in _renterList)
            {
                if(id == renter.RenterID)
                {
                    return renter;
                }
            }
            return null;
        }
        //Update by id
        public void UpdateRenter(Renter renter)
        {
            var existingRenter = GetById(renter.RenterID);
            if (existingRenter != null)
            {
                existingRenter.RenterFirstName = renter.RenterFirstName;
                existingRenter.RenterLastName = renter.RenterLastName;
                existingRenter.RenterPhoneNumber = renter.RenterPhoneNumber;
                existingRenter.RenterEmail = renter.RenterEmail;
                existingRenter.NumberOfStallsRented = renter.NumberOfStallsRented;
            }
        }
    }
}
