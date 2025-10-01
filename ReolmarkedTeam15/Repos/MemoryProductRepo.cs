using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;

namespace ReolmarkedTeam15.Repos
{
    public class MemoryProductRepo : IProductRepo
    {
        private List<Product> _productList = new List<Product>();

        public MemoryProductRepo()
        {
            _productList.Add(new Product(1001, "Keramikkop", "Blå med stjerner", 130, Product.PurchaseSituation.Købt));
            _productList.Add(new Product(1002, "Træfigur", "Bøgetræ", 120, Product.PurchaseSituation.Købt));
            _productList.Add(new Product(1001, "Halstørklæde", "Sort, håndlavet", 150, Product.PurchaseSituation.Hjemme));
        }

        //Add
        public void Add(Product product)
        {
            _productList.Add(product);
        }

        //Delete
        public void Delete(Product product)
        {
            _productList.Remove(product);
        }

        //Get All
        public IEnumerable<Product> GetAll()
        {
            return _productList;
        }

        //Get By ID
        public Product GetById(int id)
        {
            var product = _productList.FirstOrDefault(p => p.ProductID == id);
            if (product == null)
            {
                throw new ArgumentException($"No Product Found With ID {id})");
            }
            return product;
        }

        //Update
        public void Update(Product product)
        {
            var currentProduct = _productList.FirstOrDefault(p => p.ProductID == product.ProductID);
            if (currentProduct != null)
            {
                throw new ArgumentException($"No Product Found With ID {product.ProductID})");
            }

            currentProduct.Name = product.Name;
            currentProduct.Description = product.Description;
            currentProduct.Price = product.Price;
            currentProduct.PurchaseStatus = product.PurchaseStatus;
        }
    }
}
