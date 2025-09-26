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
        public List<int> usedIds = new List<int>();
        public Random _random = new Random();

        //Constructor
        public Renter(string renterFirstName, string renterLastName, string renterPhoneNumber, string renterEmail, int numberOfStallsRented)
        {
            this.RenterID = GenerateUniqueId();
            RenterFirstName = renterFirstName;
            RenterLastName = renterLastName;
            RenterPhoneNumber = renterPhoneNumber;
            RenterEmail = renterEmail;
            NumberOfStallsRented = numberOfStallsRented;
        }
        //Overloaded for Memory Samples
        public Renter(int renterID, string renterFirstName, string renterLastName, string renterPhoneNumber, string renterEmail, int numberOfStallsRented)
        {
            RenterID = renterID;
            RenterFirstName = renterFirstName;
            RenterLastName = renterLastName;
            RenterPhoneNumber = renterPhoneNumber;
            RenterEmail = renterEmail;
            NumberOfStallsRented = numberOfStallsRented;
        }

        // Metode til at generere ID
        private int GenerateUniqueId()
        {
            int id;
            do
            {
                id = _random.Next(1000, 9999);
            } while (usedIds.Contains(id));

            usedIds.Add(id);
            return id;
        }
    }
}
