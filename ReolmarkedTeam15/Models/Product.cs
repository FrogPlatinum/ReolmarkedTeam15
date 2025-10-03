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
        public int ProductStallID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public enum PurchaseSituation
        {
            Købt,
            Hjemme
        }
        public PurchaseSituation PurchaseStatus { get; set; }

        //Constructor
        public Product(int productStallID, string productName, string productDescription, int price, PurchaseSituation purchaseStatus)
        {
            ProductStallID = productStallID;
            ProductName = productName;
            ProductDescription = productDescription;
            Price = price;
            PurchaseStatus = purchaseStatus;
            ProductID = GenerateUniqueId();
        }

        //Overloaded for sample
        public Product(int productStallID, int productId, string productName, string productDescription, int price, PurchaseSituation purchaseStatus)
        {
            ProductStallID= productStallID;
            ProductID = productId;
            ProductName = productName;
            ProductDescription = productDescription;
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
