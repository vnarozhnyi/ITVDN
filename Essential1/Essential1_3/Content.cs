using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_1.Essential1_3
{
    class Content
    {
        readonly string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Content: " + content);
        }
    }
}
