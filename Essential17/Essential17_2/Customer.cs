using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17.Essential17_2
{
    struct Customer
    {
        readonly string name;
        readonly string model;
        readonly string pnumber;

        public Customer(string name, string model, string pnumber)
        {
            this.name = name;
            this.model = model;
            this.pnumber = pnumber;
        }

        public string Tel
        {
            get { return pnumber; }
        }

        public string Model
        {
            get { return model; }
        }

        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            return "Buyer: " + name + " Model: " + model + " Phone number: " + pnumber;
        }
    }
}
