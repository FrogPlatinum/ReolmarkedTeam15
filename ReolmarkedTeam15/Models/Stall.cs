using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedTeam15.Models
{
    public class Stall
    {
        public int StalldID { get; set; }
        public bool AvailabilityStatus { get; set; }
        public enum StallTypes
        {
            A,
            B
        }
        public StallTypes StallType { get; set; }
        public int Location {  get; set; }
    }
}
