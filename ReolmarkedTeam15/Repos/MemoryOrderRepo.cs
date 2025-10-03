using ReolmarkedTeam15.Interfaces;
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
    public class MemoryOrderRepo : IOrderRepo
    {
        //Memory list for Orders
        private List<Order> _orderList = new List<Order>();
        public MemoryOrderRepo()
        {
            //Sample data
            var order1 = new Order(1, new DateTime(2025, 10, 1, 12, 30, 0), 100); // 2025/October/1, 2025, 12:30 PM
            order1.PurchasedProducts.Add(new Product(3333, "Product A", "sample comment", 50, Product.PurchaseSituation.Hjemme));
            order1.PurchasedProducts.Add(new Product(4444, "Product B", "sample comment", 100, Product.PurchaseSituation.Købt));

        }
        //Add
        public void AddOrder(Order order)
        {
            if (order != null)
            {
                _orderList.Add(order);
            }
            else
            {
                throw new ArgumentNullException(nameof(order), "Null order not allowed.");
            }
        }
        //Delete
        public void DeleteOrder(Order order)
        {
            if (order != null)
            {
                _orderList.Remove(order);
            }
            else
            {
                throw new ArgumentNullException(nameof(order), "Null order not allowed.");
            }
        }

        //Get All
        public IEnumerable<Order> GetAll()
        {
            return _orderList;
        }
        //Get By ID
        public Order GetById(int id)
        {
            var order = _orderList.FirstOrDefault(o => o.OrderID == id);
            if (order == null)
            {
                throw new ArgumentException($"No order found with ID {id})");
            }
            return order;
        }
        //Update
        public void UpdateOrder(Order order)
        {
            var currentOrder = _orderList.FirstOrDefault(o => o.OrderID == order.OrderID);
            if (currentOrder == null)
            {
                throw new ArgumentException($"No order found with ID {order.OrderID})");
            }
            currentOrder.OrderDate = order.OrderDate;
            currentOrder.TotalPrice = order.TotalPrice;
            currentOrder.PurchasedProducts = order.PurchasedProducts;
        }
    }
}
