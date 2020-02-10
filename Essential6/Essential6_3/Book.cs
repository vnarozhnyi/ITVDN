using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential6.Essential6_3
{
    class Book
    {
        public class Note
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }

            }
        }

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
