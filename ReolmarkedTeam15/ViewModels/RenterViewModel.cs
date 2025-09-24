using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ReolmarkedTeam15.Helpers;
using ReolmarkedTeam15.Interfaces;
using ReolmarkedTeam15.Models;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReolmarkedTeam15.ViewModels
{
    public class RenterViewModel : BaseViewModel
    {
        private IRenterRepo _renterRepo;

        public ObservableCollection<Renter> Renters { get; }


        private string _renterFirstName;
        public string RenterFirstName
        {
            get => _renterFirstName;
            set
            {
                if (_renterFirstName != value)
                {
                    _renterFirstName = value;
                    OnPropertyChanged();
                    
                }
            }
        }
        private string _renterLastName;
        public string RenterLastName
        {
            get => _renterLastName;
            set
            {
                if (_renterLastName != value)
                {
                    _renterLastName = value;
                    OnPropertyChanged();
                   
                }
            }
        }
        private string _renterPhoneNumber;
        public string RenterPhoneNumber
        {
            get => _renterPhoneNumber;
            set
            {
                if (_renterPhoneNumber != value)
                {
                    _renterPhoneNumber = value;
                    OnPropertyChanged();
                    
                }
            }
        }
        private string _renterEmail;
        public string RenterEmail
        {
            get => _renterEmail;
            set
            {
                if (_renterEmail != value)
                {
                    _renterEmail = value;
                    OnPropertyChanged();
                   
                }
            }
        }

        public RenterViewModel(IRenterRepo renterRepo)
        {
            _renterRepo = renterRepo;
            Renters = new ObservableCollection<Renter>(_renterRepo.GetAll());

        }




        // --------------------- 4. Methods!

        //Commented out till I figure out ID.
        // Metode til at lave nyt Renter objekt ud fra tekstfelter.
        //private void RegisterRenter()
        //{
        //    var renter = new Renter(
        //                   renterID: ,
        //                   RenterFirstName,
        //                   RenterLastName,
        //                   RenterPhoneNumber,
        //                   RenterEmail);

        //    _renterRepo.AddRenter(renter);
        //    Renters.Add(renter);

        //    //Messagebox hvis vi vil have det.
        //    //System.Windows.MessageBox.Show("Ny Lejer oprettet!", MessageBoxButton.OK, MessageBoxImage.Information);

        //    ClearFields(); //Bruger denne metode efter oprettelse til at rydde tekstfelter.

        //}

        // Metode til at rydde tekstfelter i View.
        private void ClearFields()
        {
            RenterFirstName = null;
            RenterLastName = null;
            RenterPhoneNumber = null;
            RenterEmail = null;
        }

        //Metode til at tjekke om renter kan oprettes.(måske ikke helt færdig)
        private bool CanRegisterRenter()
        {
            return RenterFirstName != null && RenterLastName != null && (RenterPhoneNumber != null || RenterEmail !=null); //FirstName+LastName SKAL udfyldes + Enten Email ELLER Phone skal udfyldes.
        }

        // --------------------- 5. Commands til UI
        //Commented out till I figure out ID.
        // public RelayCommand RegisterRenterCommand => new RelayCommand(execute => RegisterRenter()); 
       // RelayCommand Bruger metode "ClearFields()" til at rydde tekstfelter i View.
        public RelayCommand ClearFieldsCommand => new RelayCommand(execute => ClearFields());



    }
}
