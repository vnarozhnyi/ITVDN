extern alias Essential;
using MyNamespaceA;
using MyNamespaceB;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();


            Console.WriteLine(new string('-', 50));


            MyDictionary<char, string> dictionary = new MyDictionary<char, string>();
            dictionary.Add('a', "Эй");
            dictionary.Add('b', "Би");
            dictionary.Add('c', "Си");
            dictionary.Add('d', "Ди");

            Console.WriteLine(dictionary['b']);

            foreach (string pair in dictionary)
                Console.WriteLine(pair);

            Console.WriteLine(new string('-', 50));

            Essential.Essential18_1.MyClass m = new Essential.Essential18_1.MyClass();

            m.Method();

            Console.ReadKey();
        }
    }
}
