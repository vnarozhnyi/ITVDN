using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential9
{
    class Program
    {
        private delegate double Mydelrgate(int a, int b, int c);
        delegate double MyDelegate(int a, int b);
        delegate int MyDel();
        delegate double Delegate(MyDel[] a);

        static int GetRandom()
        {
            return new Random().Next(100);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int k = Convert.ToInt32(Console.ReadLine());

            double del(int s, int t, int c) => (double)(s + t + c) / 3;
            Console.WriteLine("Arithmetic mean of numbers entered {0:##.###}", del(i, j, k));


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator(+,-,*,/)");
            string z = Convert.ToString(Console.ReadLine());

            MyDelegate op = null;

            switch (z)
            {
                case "+":
                    op = (x, y) => { return x + y; };
                    break;
                case "-":
                    op = (x, y) => { return x - y; };
                    break;
                case "*":
                    op = (x, y) => { return x * y; };
                    break;
                case "/":
                    op = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / (double)y;
                        }
                        else
                        {
                            Console.WriteLine("It is impossible to divide by zero!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("You entered the operation sign incorrectly!");
                    break;
            }
            Console.WriteLine(new string('-', 30));
            if (op != null)
                Console.WriteLine("{0:##.###}", op(a, b));


            Console.WriteLine(new string('-', 50));


            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new MyDel[n];

            for (int x = 0; x < array.Length; x++)
            {
                array[x] = () => new MyDel(GetRandom).Invoke();
            }

            Delegate d = delegate (MyDel[] c)
            {
                double sr = 0;
                for (int y = 0; y < c.Length; y++)
                {
                    sr += c[y].Invoke();
                }
                return sr / array.Length;
            };

            for (int e = 0; e < array.Length; e++)
            {
                Console.Write(array[e].Invoke() + " ");
            }

            Console.WriteLine("\nArithmetic mean of elements {0:##.###}", d(array));

            Console.ReadKey();
        }
    }
}
