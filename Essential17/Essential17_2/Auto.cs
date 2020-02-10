using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17.Essential17_2
{
    struct Auto
    {
        readonly string brand;
        readonly string model;
        readonly int year;
        private readonly string color;

        public Auto(string brand, string model, int year, string color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public string Color
        {
            get { return color; }
        }

        public string Model
        {
            get { return model; }
        }

        public int Year
        {
            get { return year; }
        }

        public string Brand
        {
            get { return brand; }
        }

        public override string ToString()
        {
            return "Brand: " + brand + " Model: " + model + " Year of issue: " + year + " Color: " + color;
        }
    }
}
