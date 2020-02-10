using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4.Essential4_1.Document
{
    class Body : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "The body of the document is missing.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
