using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedTeam15.Models
{
    public class Order
    {
        public List<int> usedOrderIDs = new List<int>(); //Bruges så vi ikke får duplicates af ID.
        public Random _random = new Random();
        //Properties
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public ObservableCollection<Product> PurchasedProducts { get; set; }
        public int TotalPrice { get; set; } //double to int (according to product)

        //Constructor
        public Order(DateTime orderDate, int totalPrice)
        {
            OrderID = GenerateUniqueId();
            OrderDate = orderDate;
            PurchasedProducts = new ObservableCollection<Product>();
            TotalPrice = totalPrice;
        }
        //Overloaded for Memory Samples
        public Order(int orderID, DateTime orderDate, int totalPrice)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            PurchasedProducts = new ObservableCollection<Product>();
            TotalPrice = totalPrice;
        }
        private int GenerateUniqueId()
        {
            int id;
            do
            {
                id = _random.Next(1000, 9999);
            } while (usedOrderIDs.Contains(id));

            usedOrderIDs.Add(id);
            return id;
        }
    }
}
