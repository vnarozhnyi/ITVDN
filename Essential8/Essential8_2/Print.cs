using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential8.Essential8_2
{
    enum Colors
    {
        Blue = 0,
        Red = 1,
        Green = 2
    }

    static class MyClass
    {
        public static void Print(string line, int color)
        {
            switch (color)
            {
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("The line you entered will be displayed in the default color!");
                    break;
            }

            Console.WriteLine(line);
        }
    }
}
