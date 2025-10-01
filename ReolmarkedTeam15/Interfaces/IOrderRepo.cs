using ReolmarkedTeam15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedTeam15.Interfaces
{
    public interface IOrderRepo
    {
        public void AddOrder(Order order);
        public IEnumerable<Order> GetAll();
        public Order GetById(int id);
        public void UpdateOrder(Order order);
        public void DeleteOrder(Order order);
    }
}
