using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3.Essential3_3
{
        class Car : Vehicle
        {
            public Car(int xLocation, int yLocation, uint price, uint speed, uint year)
                : base(xLocation, yLocation, price, speed, year)
            {

            }
            public Car(uint price, uint speed, uint year)
                : base(price, speed, year)
            {

            }
        }
}
