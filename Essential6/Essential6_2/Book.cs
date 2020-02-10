using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential6.Essential6_2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("String search : " + str);
        }
    }

    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }
}
