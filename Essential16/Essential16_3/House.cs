using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential16.Essential16_3
{
    class House
    {
        private string city;
        private Street street;

        public House(Street street, string city)
        {
            this.street = street;
            this.city = city;
        }

        public House Clone()
        {
            return this; 
        }

        public House DeepClone()
        {
            return new House(this.street.Clone() as Street, this.City);
        }

        public Street Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}
