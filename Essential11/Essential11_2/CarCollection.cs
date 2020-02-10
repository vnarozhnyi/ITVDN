using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential11.Essential11_2
{
    class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public new string this[int index]
        {
            get
            {
                if (index < carName.Count)
                    return carName[index] + " " + carYear[index].Year + " г";
                return "There is no car in the list with this number!";
            }
        }

        public int Lenght
        {
            get { return carName.Count; }
        }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string stringS = null;
            for (int i = 0; i < carName.Count; i++)
            {
                stringS += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г \n";
            }
            if (stringS != null) return stringS;
            return "There are no cars in the park!";
        }
    }
}
