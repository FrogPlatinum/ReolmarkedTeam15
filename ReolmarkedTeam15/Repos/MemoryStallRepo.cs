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
            Stall sampleStall1 = new Stall(01, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 1);
            _stallList.Add(sampleStall1);

            Stall sampleStall2 = new Stall(02, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 2);
            _stallList.Add(sampleStall2);

            Stall sampleStall3 = new Stall(03, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.A, 3);
            _stallList.Add(sampleStall3);

            Stall sampleStall4 = new Stall(04, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 4);
            _stallList.Add(sampleStall4);

            Stall sampleStall5 = new Stall(05, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 5);
            _stallList.Add(sampleStall5);

            Stall sampleStall6 = new Stall(06, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.B, 6);
            _stallList.Add(sampleStall6);

            Stall sampleStall7 = new Stall(07, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 7);
            _stallList.Add(sampleStall7);

            Stall sampleStall8 = new Stall(08, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 8);
            _stallList.Add(sampleStall8);

            Stall sampleStall9 = new Stall(09, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 9);
            _stallList.Add(sampleStall9);

            Stall sampleStall10 = new Stall(010,Stall.AvailabilityStatus.Ledig,Stall.StallTypes.A,10);
            _stallList.Add(sampleStall10);

            Stall sampleStall11 = new Stall(011, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 11);
            _stallList.Add(sampleStall11);

            Stall sampleStall12 = new Stall(012, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 12);
            _stallList.Add(sampleStall12);

            Stall sampleStall13 = new Stall(013, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 13);
            _stallList.Add(sampleStall13);

            Stall sampleStall14 = new Stall(014, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 14);
            _stallList.Add(sampleStall14);

            Stall sampleStall15 = new Stall(015, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 15);
            _stallList.Add(sampleStall15);

            Stall sampleStall16 = new Stall(016, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 16);
            _stallList.Add(sampleStall16);

            Stall sampleStall17 = new Stall(017, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 17);
            _stallList.Add(sampleStall17);

            Stall sampleStall18 = new Stall(018, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 18);
            _stallList.Add(sampleStall18);

            Stall sampleStall19 = new Stall(019, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 19);
            _stallList.Add(sampleStall19);

            Stall sampleStall20 = new Stall(020, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.B, 20);
            _stallList.Add(sampleStall20);

            Stall sampleStall21 = new Stall(021, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.B, 21);
            _stallList.Add(sampleStall21);

            Stall sampleStall22 = new Stall(022, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.B, 22);
            _stallList.Add(sampleStall22);

            Stall sampleStall23 = new Stall(023, Stall.AvailabilityStatus.Optaget, Stall.StallTypes.B, 23);
            _stallList.Add(sampleStall23);

            Stall sampleStall24 = new Stall(024, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 24);
            _stallList.Add(sampleStall24);

            Stall sampleStall25 = new Stall(025, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 25);
            _stallList.Add(sampleStall25);

            Stall sampleStall26 = new Stall(026, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 26);
            _stallList.Add(sampleStall26);

            Stall sampleStall27 = new Stall(027, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 27);
            _stallList.Add(sampleStall27);

            Stall sampleStall28 = new Stall(028, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 28);
            _stallList.Add(sampleStall28);

            Stall sampleStall29 = new Stall(029, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 29);
            _stallList.Add(sampleStall29);

            Stall sampleStall30 = new Stall(030, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 30);
            _stallList.Add(sampleStall30);

            Stall sampleStall31 = new Stall(031, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 31);
            _stallList.Add(sampleStall31);

            Stall sampleStall32 = new Stall(032, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 32);
            _stallList.Add(sampleStall32);

            Stall sampleStall33 = new Stall(033, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 33);
            _stallList.Add(sampleStall33);

            Stall sampleStall34 = new Stall(034, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 34);
            _stallList.Add(sampleStall34);

            Stall sampleStall35 = new Stall(035, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 35);
            _stallList.Add(sampleStall35);

            Stall sampleStall36 = new Stall(036, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 36);
            _stallList.Add(sampleStall36);

            Stall sampleStall37 = new Stall(037, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 37);
            _stallList.Add(sampleStall37);

            Stall sampleStall38 = new Stall(038, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 38);
            _stallList.Add(sampleStall38);

            Stall sampleStall39 = new Stall(039, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 39);
            _stallList.Add(sampleStall39);

            Stall sampleStall40 = new Stall(040, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 40);
            _stallList.Add(sampleStall40);

            Stall sampleStall41 = new Stall(041, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 41);
            _stallList.Add(sampleStall41);

            Stall sampleStall42 = new Stall(042, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 42);
            _stallList.Add(sampleStall42);

            Stall sampleStall43 = new Stall(043, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 43);
            _stallList.Add(sampleStall43);

            Stall sampleStall44 = new Stall(044, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 44);
            _stallList.Add(sampleStall44);

            Stall sampleStall45 = new Stall(045, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 45);
            _stallList.Add(sampleStall45);

            Stall sampleStall46 = new Stall(046, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 46);
            _stallList.Add(sampleStall46);

            Stall sampleStall47 = new Stall(047, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 47);
            _stallList.Add(sampleStall47);

            Stall sampleStall48 = new Stall(048, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 48);
            _stallList.Add(sampleStall48);

            Stall sampleStall49 = new Stall(049, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 49);
            _stallList.Add(sampleStall49);

            Stall sampleStall50 = new Stall(050, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 50);
            _stallList.Add(sampleStall50);

            Stall sampleStall51 = new Stall(051, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 51);
            _stallList.Add(sampleStall51);

            Stall sampleStall52 = new Stall(052, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 52);
            _stallList.Add(sampleStall52);

            Stall sampleStall53 = new Stall(053, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 53);
            _stallList.Add(sampleStall53);

            Stall sampleStall54 = new Stall(054, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 54);
            _stallList.Add(sampleStall54);

            Stall sampleStall55 = new Stall(055, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 55);
            _stallList.Add(sampleStall55);

            Stall sampleStall56 = new Stall(056, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 56);
            _stallList.Add(sampleStall56);

            Stall sampleStall57 = new Stall(057, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 57);
            _stallList.Add(sampleStall57);

            Stall sampleStall58 = new Stall(058, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 58);
            _stallList.Add(sampleStall58);

            Stall sampleStall59 = new Stall(059, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 59);
            _stallList.Add(sampleStall59);

            Stall sampleStall60 = new Stall(060, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 60);
            _stallList.Add(sampleStall60);

            Stall sampleStall61 = new Stall(061, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 61);
            _stallList.Add(sampleStall61);

            Stall sampleStall62 = new Stall(062, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 62);
            _stallList.Add(sampleStall62);

            Stall sampleStall63 = new Stall(063, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 63);
            _stallList.Add(sampleStall63);

            Stall sampleStall64 = new Stall(064, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 64);
            _stallList.Add(sampleStall64);

            Stall sampleStall65 = new Stall(065, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 65);
            _stallList.Add(sampleStall65);

            Stall sampleStall66 = new Stall(066, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 66);
            _stallList.Add(sampleStall66);

            Stall sampleStall67 = new Stall(067, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 67);
            _stallList.Add(sampleStall67);

            Stall sampleStall68 = new Stall(068, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 68);
            _stallList.Add(sampleStall68);

            Stall sampleStall69 = new Stall(069, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 69);
            _stallList.Add(sampleStall69);

            Stall sampleStall70 = new Stall(070, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 70);
            _stallList.Add(sampleStall70);

            Stall sampleStall71 = new Stall(071, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 71);
            _stallList.Add(sampleStall71);

            Stall sampleStall72 = new Stall(072, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 72);
            _stallList.Add(sampleStall72);

            Stall sampleStall73 = new Stall(073, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 73);
            _stallList.Add(sampleStall73);

            Stall sampleStall74 = new Stall(074, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 74);
            _stallList.Add(sampleStall74);

            Stall sampleStall75 = new Stall(075, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 75);
            _stallList.Add(sampleStall75);

            Stall sampleStall76 = new Stall(076, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 76);
            _stallList.Add(sampleStall76);

            Stall sampleStall77 = new Stall(077, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 77);
            _stallList.Add(sampleStall77);

            Stall sampleStall78 = new Stall(078, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.A, 78);
            _stallList.Add(sampleStall78);

            Stall sampleStall79 = new Stall(079, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 79);
            _stallList.Add(sampleStall79);

            Stall sampleStall80 = new Stall(080, Stall.AvailabilityStatus.Ledig, Stall.StallTypes.B, 80);
            _stallList.Add(sampleStall80);
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
