using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proffesional11
{
    class Program
    {
        static private int counter = 0;

        static private object block = new object();

        static private void Function1()
        {
            lock (block)
            {
                for (int i = 0; i < 50; ++i)
                {
                    Monitor.Wait(block, Timeout.Infinite);
                    Console.Write("1 ");
                    Console.WriteLine("{0} из потока {1}", ++counter, Thread.CurrentThread.GetHashCode());
                    Monitor.Pulse(block);
                }
            }
        }

        static private void Function2()
        {
            lock (block)
            {
                for (int i = 0; i < 50; ++i)
                {
                    Monitor.Wait(block, Timeout.Infinite);
                    Console.Write("2 ");
                    Console.WriteLine("{0} из потока {1}", ++counter, Thread.CurrentThread.GetHashCode());
                    Monitor.Pulse(block);
                }
            }
        }

        static private void Function3()
        {
            lock (block)
            {
                for (int i = 0; i < 50; ++i)
                {
                    Monitor.Pulse(block);
                    Monitor.Wait(block, Timeout.Infinite);
                    Console.Write("3 ");
                    Console.WriteLine("{0} из потока {1}", ++counter, Thread.CurrentThread.GetHashCode());
                }
            }
        }

        static readonly StreamReader stream1 = File.OpenText("text1.txt");
        static readonly StreamReader stream2 = File.OpenText("text2.txt");
        static readonly StreamWriter stream3 = File.CreateText("text3.txt");

        static object blok = new object();

        static void ReadText1()
        {
            string str = stream1.ReadToEnd();

            lock (blok)
            {
                stream3.WriteLine(str);
            }
        }

        static void ReadText2()
        {
            string str = stream2.ReadToEnd();

            lock (blok)
            {
                stream3.WriteLine(str);
            }
        }

        static void Main(string[] args)
        {
            Thread[] threads = { new Thread(Function1), new Thread(Function2), new Thread(Function3) };

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            Console.ReadKey();

            Thread[] array = new Thread[] { new Thread(ReadText1), new Thread(ReadText2) };

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Start();
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Join();
            }

            stream3.Close();
        }
    }
}
