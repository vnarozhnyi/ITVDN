using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2.Essential2_2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ToUSD(double uahSum)
        {
            Console.WriteLine(uahSum / usd);
        }

        public void FromUSD(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }

        public void ToEUR(double uahSum)
        {
            Console.WriteLine(uahSum / eur);
        }

        public void FromEUR(double eurSum)
        {
            Console.WriteLine(eurSum * eur);
        }

        public void ToRUB(double uahSum)
        {
            Console.WriteLine(uahSum / rub);
        }

        public void FromRUB(double rubSum)
        {
            Console.WriteLine(rubSum * usd);
        }
    }
}
