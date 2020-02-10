using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_1
{
    class Address
    {
        private string index;
        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;
        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
