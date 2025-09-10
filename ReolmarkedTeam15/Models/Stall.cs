using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedTeam15.Models
{
    public class Stall
    {
        //Attributes
        public int StallID { get; set; }
        public enum AvailabilityStatus
        {
            Ledig,
            Optaget
        }
        public AvailabilityStatus Availability { get; set; }
        public enum StallTypes
        {
            A,
            B
        }
        public StallTypes StallType { get; set; }
        public int Location {  get; set; }

        //Constructor
        public Stall(int stallId, AvailabilityStatus availability, StallTypes stallType, int location)
        {
            StallID = stallId;
            Availability = availability;
            StallType = stallType;
            Location = location;
        }
    }
}
