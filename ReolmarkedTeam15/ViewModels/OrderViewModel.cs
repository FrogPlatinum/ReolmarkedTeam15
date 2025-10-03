using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Helpers;
using System.Collections.ObjectModel;

namespace ReolmarkedTeam15.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        //Repo
        private IOrderRepo _orderRepo;
        private IProductRepo _productRepo;

        //List for View
        public ObservableCollection<Product> ProductsInCart { get; }

        //Orders list for History
        private List<Order> _orderHistory = new List<Order>();

        //Wrappers
        private int _productIDInput;
        public int ProductIDInput
        {
            get => _productIDInput;
            set
            {
                _productIDInput = value;
                OnPropertyChanged();
            }
        }

        private int _orderTotalPrice;
        public int OrderTotalPrice
        {
            get => _orderTotalPrice;
            set
            {
                _orderTotalPrice = value;
                OnPropertyChanged();
            }
        }

        //Commands
        public ICommand AddProductToCartCommand { get; }
        //public ICommand CheckOutCommand { get; }


        //Constructor
        public OrderViewModel(IOrderRepo orderRepo, IProductRepo productRepo)
        {
            _orderRepo = orderRepo;
            _productRepo = productRepo;

            ProductsInCart = new ObservableCollection<Product>();

            AddProductToCartCommand = new RelayCommand(AddProductToCart);
            //CheckOutCommand = new RelayCommand(CheckOut);
        }

        //Add with product id to cart
        private void AddProductToCart()
        {
            var product = _productRepo.GetAll().FirstOrDefault(p => p.ProductID == ProductIDInput);
            ProductsInCart.Add(product);
            OrderTotalPrice = ProductsInCart.Sum(p => p.Price);
        }

        //Didn't get to finish it :(
        //private void CheckOut()
        //{
        //    if(ProductsInCart.Count > 0)
        //    {
        //        var newOrder = new Order
        //        {
        //            OrderID = newOrder.
        //        };
        //    }
        //}
    }
}
