using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential13
{

    class Program
    {
        static int deep;

        static public void Recursion()
        {
            Console.WriteLine("{0}  say  \"Hello!\"", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Thread thread = new Thread(Recursion);
            deep++;
            thread.Name = "Thread " + deep;
            thread.Start();
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(Recursion) { Name = "Thread " + deep };
            thread.Start();


            Console.SetWindowSize(80, 40);

            Matrix instance;

            for (int i = 0; i < 30; i++)
            {
                instance = new Matrix(i * 2);
                new Thread(instance.Move).Start();
            }


            Console.ReadKey();


        }
    }
}
