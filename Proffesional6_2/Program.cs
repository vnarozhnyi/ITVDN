using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("Proffesional6");

            dynamic instance = Activator.CreateInstance(assembly.GetType("Proffesional6.Temperature"));

            Console.WriteLine("15 ° C to ° F equals " + instance.Fahrenheit(15m));

            Console.ReadKey();
        }
    }
}
