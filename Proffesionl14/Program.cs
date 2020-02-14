using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proffesionl14
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 () is running.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In Method1 (), the counter is: " + count);
            }
            Console.WriteLine("Method1 () completed.");
        }

        static void Method2()
        {
            Console.WriteLine("Method2() is running.");
            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In Method2 (), the counter is: " + count);
            }
            Console.WriteLine("Method2() completed.");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            var query = array.AsParallel().Where((i) => i % 2 != 0).Select((i) => i);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            Console.WriteLine("The main thread is running.");

            Task.Factory.StartNew(() => Parallel.Invoke(Method1, Method2));

            Console.WriteLine("The main thread is completed.");

            Console.ReadKey();
        }
    }
}
