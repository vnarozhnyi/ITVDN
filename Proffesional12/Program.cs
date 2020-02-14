using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proffesional12
{
    class Program
    {
        private static Semaphore pool;

        private static void Work(object number)
        {
            pool.WaitOne();

            File.AppendAllText("log.txt", string.Format("Поток {0} занял слот семафора.", number));
            Thread.Sleep(1000);
            File.AppendAllText("log.txt", string.Format("Поток {0} -----> освободил слот.", number));

            pool.Release();
        }

        private static readonly Mutex Mutex1 = new Mutex(false, "MutexSample:AAED7056-380D-412E-9608-763495211EA8");

        static void Main(string[] args)
        {
            pool = new Semaphore(1, 4);

            for (int i = 1; i <= 8; i++)
            {
                Thread threads = new Thread(new ParameterizedThreadStart(Work));
                threads.Start(i);
            }


            Console.WriteLine(new string('-', 50));


            var auto = new AutoResetEvent(false);

            var thread = new Work("1", auto);
            Console.WriteLine("The main thread is waiting for the event.\n");

            auto.WaitOne();
            Console.WriteLine("\nThe main thread received an event notification from the first thread.\n");

            thread = new Work("2", auto);
            Console.WriteLine("The main thread is waiting for the event.\n");

            auto.WaitOne();
            Console.WriteLine("\nThe main thread received an event notification from the second thread.");

            Console.ReadKey();

            Mutex1.WaitOne();

            Console.WriteLine("Stream {0} has entered a protected area.", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Stream {0} has left the protected area.\n", Thread.CurrentThread.Name);

            Console.ReadKey();
            Mutex1.ReleaseMutex();
        }
    }
}
