using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential15.Essential15_3
{
    class PriceTable
    {
        struct Prices
        {
            string shop;
            string number;
            uint? price;

            public string Shop
            {
                get { return shop; }
            }

            public string Number
            {
                get { return number; }
            }

            public uint? Price
            {
                get { return price; }
            }

            public Prices(string number, string shop, uint? price)
            {
                this.shop = shop;
                this.price = price;
                this.number = number;
            }

            public string Show()
            {
                return string.Format("Product number {0} from store {1} costs {2}", number, shop, price);
            }
        }

        Prices[] product;

        public PriceTable()
        {
            product = new Prices[2];
            string shop;
            string number;
            uint? price;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter item number");
                number = Console.ReadLine();

                Console.WriteLine("Enter store");
                shop = Console.ReadLine();

                Console.WriteLine("Enter price");
                try
                {
                    price = Convert.ToUInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Attempted to write the wrong format.");
                    Console.WriteLine(e.Message);
                    price = null;
                }
                product[i] = new Prices(number, shop, price);
            }
            product = product.OrderBy(products => products.Number).ToArray<Prices>();
        }

        public string this[int index]
        {
            get
            {
                try
                {
                    return product[index].Show();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An attempt to access outside the array.");
                    Console.WriteLine(e.Message);
                    return "";
                }
            }
        }

        public string this[string index]
        {
            get
            {

                try
                {
                    return product[Convert.ToInt32(index) - 1].Show();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An attempt to access outside the array.");
                    Console.WriteLine(e.Message);
                    return string.Format("\"{0}\" there is no such product.", index);
                }
            }
        }

    }
}
