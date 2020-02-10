using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4.Essential4_2
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " is open");
        }

        public void Create()
        {
            Console.WriteLine(fileName + " created");
        }

        public void Chenge()
        {
            Console.WriteLine(fileName + " edited");
        }

        public abstract void Save();
    }    
}

