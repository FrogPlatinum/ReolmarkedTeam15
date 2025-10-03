using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Helpers;
using static ReolmarkedTeam15.Models.Product;

namespace ReolmarkedTeam15.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        //Repo
        private IProductRepo _productRepo;

        //List for View
        public ObservableCollection<Product> Products { get; }
        public ObservableCollection<Stall> Stalls { get; }

        //Wrappers
        private int _productStallID;
        public int ProductStallID
        {
            get => _productStallID;
            set
            {
                _productStallID = value;
                OnPropertyChanged();
            }
        }

        private int _productID;
        public int ProductID
        {
            get => _productID;
            set
            {
                _productID = value;
                OnPropertyChanged();
            }
        }

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }

        private string _productDescription;
        public string ProductDescription
        {
            get => _productDescription;
            set
            {
                _productDescription = value;
                OnPropertyChanged();
            }
        }

        private int _price;
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        private PurchaseSituation _purchaseStatus;
        public PurchaseSituation PurchaseStatus
        {
            get => _purchaseStatus;
            set
            {
                _purchaseStatus = value;
                OnPropertyChanged();
            }
        }

        //Selected Stall
        private Stall _selectedStall;
        public Stall SelectedStall
        {
            get => _selectedStall;
            set
            {
                _selectedStall = value;
                OnPropertyChanged();
            }
        }

        //Commands
        public ICommand AddProductCommand { get; }
        public ICommand ClearFieldsCommand { get; }

        //Constructor
        public ProductViewModel(IProductRepo productRepo, IStallRepo stallRepo)
        {
            _productRepo = productRepo;
            Products = new ObservableCollection<Product>(_productRepo.GetAll());

            //Pulling Stalls to ProductViewModel
            Stalls = new ObservableCollection<Stall>(stallRepo.GetAll());

            AddProductCommand = new RelayCommand(AddProduct);
            ClearFieldsCommand = new RelayCommand(ClearFields);
        }


        //Add Product
        public void AddProduct()
        {
            var newProduct = new Product(SelectedStall.StallID, ProductName, ProductDescription, Price, Product.PurchaseSituation.Hjemme);
            _productRepo.Add(newProduct);
            Products.Add(newProduct);

        }

        //Clear field
        public void ClearFields()
        {
            ProductName = string.Empty;
            ProductDescription = string.Empty;
            Price = 0;
        }
    }
}
