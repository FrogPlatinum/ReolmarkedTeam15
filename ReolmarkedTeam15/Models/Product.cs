using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedTeam15.Models
{
    public class Product
    {
        //Random unique ID
        public List<int> usedIds = new List<int>(); //Bruges så vi ikke får duplicates af ID.
        public Random _random = new Random();

        //Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public enum PurchaseSituation
        {
            Købt,
            Hjemme
        }
        public PurchaseSituation PurchaseStatus { get; set; }

        //Constructor
        public Product(string name, string description, int price, PurchaseSituation purchaseStatus)
        {
            ProductID = GenerateUniqueId();
            Name = name;
            Description = description;
            Price = price;
            PurchaseStatus = purchaseStatus;
        }

        //Overloaded for sample
        public Product(int productId, string name, string description, int price, PurchaseSituation purchaseStatus)
        {
            ProductID = productId;
            Name = name;
            Description = description;
            Price = price;
            PurchaseStatus = purchaseStatus;
        }

        private int GenerateUniqueId()
        {
            int id;
            do
            {
                id = _random.Next(1000, 9999);
            } while (usedIds.Contains(id));

            usedIds.Add(id); //Her tilføjer den det genererede id til UsedIds.
            return id;
        }
    }
}
