using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.Interfaces
{
    public interface IProductRepo
    {
        public void Add(Product product);
        public IEnumerable<Product> GetAll();
        public Product GetById(int id);
        public void Update(Product product);
        public void Delete(Product product);
    }
}
