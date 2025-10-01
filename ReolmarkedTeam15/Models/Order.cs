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
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public ObservableCollection<Order> PurchasedProducts { get; set; }
        public double TotalPrice { get; set; }

        //Constructor
        public Order(int orderID, DateTime orderDate, double totalPrice)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            PurchasedProducts = new ObservableCollection<Order>();
            TotalPrice = totalPrice;
        }
    }
}
