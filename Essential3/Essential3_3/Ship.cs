using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3.Essential3_3
{
    class Ship : Vehicle
    {
        private string port;
        private int passengers;

        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        public Ship(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }

        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("The number of passengers cannot be negative");
                }
                else
                {
                    passengers = value;
                }
            }
        }

        public string Port
        {
            get
            {
                if (port == null)
                    return "Port not set";
                return port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("The value is empty");
                }
                else
                {
                    port = value;
                }
            }
        }
    }

}
