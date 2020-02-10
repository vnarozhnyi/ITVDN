using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4.Essential4_2
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " saved in DOC format");
        }
    }
}
