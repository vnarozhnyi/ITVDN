using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proffesional9
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var myClass = new MyClass())
            {
                Console.WriteLine(myClass);
            }
            Console.WriteLine(new string('-', 20));


            var myClass2 = new MyClass();
            Console.WriteLine(myClass2);

            myClass2.Dispose();
            myClass2.Dispose();
            myClass2.Dispose();
            myClass2.Dispose();

            var myClass3 = new MyClass();

            Console.ReadKey();
            Console.WriteLine("Press any key to dispose");


            Timer timer = new Timer(new MonitorMemory(100000000).WarnIfMemoryLimitExceeded, "Warning memory out", 0, 200);

            LargeObject[] array = new LargeObject[1000];

            for (int i = 0; i < array.Length; i++)
            {
                new LargeObject().Method(i);
            }

            Console.ReadKey();
        }
    }
}
