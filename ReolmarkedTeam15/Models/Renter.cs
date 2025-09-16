using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedTeam15.Models
{
    public class Renter
    {
        public int RenterID { get; set; }
        public string RenterFirstName { get; set; }
        public string RenterLastName { get; set; }
        public string RenterPhoneNumber { get; set; }
        public string RenterEmail { get; set; }
        public int NumberOfStallsRented { get; set; }

        //Constructor
        public Renter(int renterId, string renterFirstName, string renterLastName, string renterPhoneNumber, string renterEmail, int numberOfStallsRented)
        {
            RenterID = renterId;
            RenterFirstName = renterFirstName;
            RenterLastName = renterLastName;
            RenterPhoneNumber = renterPhoneNumber;
            RenterEmail = renterEmail;
            NumberOfStallsRented = numberOfStallsRented;
        }
    }
}
