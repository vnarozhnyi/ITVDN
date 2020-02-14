using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proffesional12
{
    class Work
    {
        readonly AutoResetEvent auto;
        readonly Thread thread;

        public Work(string name, AutoResetEvent auto)
        {
            this.thread = new Thread(this.Run) { Name = name };
            this.auto = auto;
            this.thread.Start();
        }

        void Run()
        {
            Console.WriteLine("Stream started " + thread.Name);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(200);
            }

            Console.WriteLine("\nStream " + thread.Name + " completed");

            auto.Set();
        }
    }
}
