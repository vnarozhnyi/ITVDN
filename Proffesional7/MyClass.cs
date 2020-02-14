using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional7
{
    class MyClass
    {
        [Obsolete("Method is obsolete")]
        public void ObsoleteMessage()
        {
            Console.WriteLine("Hello world!");
        }

        [Obsolete("The method is not used", true)]
        public void ObsoleteError()
        {
            Console.WriteLine("Hello world!");
        }

    }
}
