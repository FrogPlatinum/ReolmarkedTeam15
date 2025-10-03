using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ReolMarked
{
    [TestClass]
    public class MemoryOrderRepoTests
    {
        private MemoryOrderRepo _orderRepo;

        [TestInitialize]
        public void Setup()
        {
            // Initialize repo
            _orderRepo = new MemoryOrderRepo();
        }

        //Add order test
        [TestMethod]
        public void AddOrder_ShouldAddOrderToList()
        {
            // Arrange
            var order = new Order(2, new DateTime(2025, 10, 2, 10, 0, 0), 150);
            order.PurchasedProducts.Add(new Product(4444, "Product A", "sample", 75, Product.PurchaseSituation.Købt));
            
            // Act
            _orderRepo.AddOrder(order);

            // Assert
            var orders = _orderRepo.GetAllOrders();
            Assert.AreEqual(1, orders.Count(), "Order count should be 1 after adding order.");
        }

        //Remove order test
        [TestMethod]
        public void DeleteOrder_ShouldRemoveOrderFromList()
        {
            // Arrange
            var order = new Order(3, new DateTime(2025, 10, 3, 14, 30, 0), 200);
            order.PurchasedProducts.Add(new Product(5555, "Product B", "sample", 100, Product.PurchaseSituation.Hjemme));
            _orderRepo.AddOrder(order);

            // Act
            _orderRepo.DeleteOrder(order);

            // Assert
            var orders = _orderRepo.GetAllOrders();
            Assert.AreEqual(0, orders.Count(), "Order count should be 0 after deleting order.");
        }

        //Get by ID test
        [TestMethod]
        public void GetById_ShouldReturnCorrectOrder()
        {
            // Arrange
            var order = new Order(4, new DateTime(2025, 10, 4, 15, 0, 0), 300);
            order.PurchasedProducts.Add(new Product(6666, "Product C", "sample", 150, Product.PurchaseSituation.Købt));
            _orderRepo.AddOrder(order);

            // Act
            var retrievedOrder = _orderRepo.GetById(order.OrderID);

            // Assert
            Assert.AreEqual(order.OrderID, retrievedOrder.OrderID, "Order ID should match.");
            Assert.AreEqual(order.TotalPrice, retrievedOrder.TotalPrice, "Total price should match.");
        }
        //Update order test
        [TestMethod]
        public void Update_ShouldUpdateOrder()
        {
            // Arrange
            var order = new Order(5, new DateTime(2025, 10, 5, 16, 0, 0), 400);
            order.PurchasedProducts.Add(new Product(7777, "Product D", "existing product", 200, Product.PurchaseSituation.Hjemme));
            _orderRepo.AddOrder(order);

            // Act
            order.TotalPrice = 500;
            _orderRepo.Update(order);

            // Assert
            var updatedOrder = _orderRepo.GetById(order.OrderID);
            Assert.AreEqual(500, updatedOrder.TotalPrice, "Total price should update.");
        }
    }
}
