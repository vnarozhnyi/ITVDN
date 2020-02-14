using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional13_2
{
    class Program
    {
        static void Method()
        {
            Console.WriteLine("Async method started.");
            Console.WriteLine("Async operation completed.\n");
        }

        static void HandleCompletion(IAsyncResult asyncResult)
        {
            Console.WriteLine("Async Operation Information - " + asyncResult.AsyncState);
        }

        static void Main(string[] args)
        {
            var myDelegate = new Action(Method);

            var callback = new AsyncCallback(HandleCompletion);

            myDelegate.BeginInvoke(callback, "Hello world");

            Console.ReadKey();
        }
    }
}
