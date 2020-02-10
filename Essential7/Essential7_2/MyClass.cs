using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential7.Essential7_2
{
    public static class MyClass
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int q = 0; q < trains.Length; q++)
                {
                    if (trains[i].Number <= trains[q].Number)
                    {
                        Train g = trains[i];
                        trains[i] = trains[q];
                        trains[q] = g;
                    }
                }
            }
        }

        public static void Search(Train[] train, int poisk)
        {
            bool ok = false;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == poisk)
                {
                    Console.WriteLine("Train number: {0} Destination: {1} Date and time of departure: {2} ",
                                      train[i].Number, train[i].Destination, train[i].Time);
                    ok = true;

                }
            }
            if (!ok)
                Console.WriteLine("Train not found!");
        }

        public static void AddingAnArray(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write("Enter train destination:");
                string destination = Console.ReadLine();
                destination = string.IsNullOrEmpty(destination) ? "Destination not specified" : destination;

                Console.Write("Enter train number:");
                string d = Console.ReadLine();
                int number = string.IsNullOrEmpty(d) ? 0 : Convert.ToInt32(d);

                Console.Write("Enter departure date:");
                d = Console.ReadLine();
                DateTime date = string.IsNullOrEmpty(d) ? DateTime.Now : DateTime.Parse(d);

                train[i] = new Train(destination, number, date);
            }
        }

        public static void Show(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Train number: {0} Destination: {1} Date and time of departure: {2} ", train[i].Number,
                                  train[i].Destination, train[i].Time);

            }
        }
    }
}
