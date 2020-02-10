using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5.Essential5_4
{
    class Article
    {
        double price;

        public string Name { get; private set; }
        public string Shop { get; set; }

        public double Price
        {
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Cost cannot be negative");
            }
            get { return price; }
        }

        public Article(string name)
        {
            Name = name;
        }

        public Article(string name, string shop, double price)
        {
            Name = name;
            Shop = shop;
            Price = price;
        }

        public string Info()
        {
            return string.Format("{0} of {1} cost: {2} UAH.", Name, Shop, Price);
        }
    }
}
