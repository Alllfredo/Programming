using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public int Index
        {
            get { return _index; }
            set
            {
                Validator.AssertOnPositiveValue(value, 100_000, 999_999, nameof(value));
                _index = value;
            }
        }
        public string Country
        { 
            get { return _country; }
            set
            {
                Validator.AssertStringOnLength(value, 50, nameof(value));
                _country = value;
            }
        }

        public string City
        { 
            get { return _city; }
            set
            {
                Validator.AssertStringOnLength(value, 50, nameof(value));
                _city = value;
            }
        }

        public string Street
        { 
            get { return _street; }
            set
            {
                Validator.AssertStringOnLength(value, 100, nameof(value));
                _street = value;
            }
        }

        public string Building
        { 
            get { return _building; }
            set
            {
                Validator.AssertStringOnLength(value, 10, nameof(value));
                _building = value;
            }
        }

        public string Apartment
        { 
            get { return _apartment; }
            set
            {
                Validator.AssertStringOnLength(value, 10, nameof(value));
                _apartment = value;
            }
        }

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        public Address(Address adress)
        {
            Index = adress.Index;
            Country = adress.Country;
            City = adress.City;
            Street = adress.Street;
            Building = adress.Building;
            Apartment = adress.Apartment;
        }
        public Address() { }
    }
}
