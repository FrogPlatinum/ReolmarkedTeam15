using ReolmarkedTeam15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace ReolmarkedTeam15.Repos
{
    public class MemoryOrderRepo
    {
        //Memory list for Orders
        private List<Order> _orderList = new List<Order>();
        public MemoryOrderRepo()
        {
            //Sample data
            var order1 = new Order(1, new DateTime(2025, 10, 1, 12, 30, 0), 99.99); // 2025/October/1, 2025, 12:30 PM
            order1.PurchasedProducts.Add(new Product(3333, "Product A", 20, 49.99, Product.Status.Hjemme));
            order1.PurchasedProducts.Add(new Product(444, "Product B", 20, 50.00, Product.Status.Hjemme));
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderList;
        }

        public Order GetOrderById(int orderId)
        {
            return _orderList.Find(order => order.OrderID == orderId);
        }

        public void AddOrder(Order order)
        {
            _orderList.Add(order);
        }
    }
}
