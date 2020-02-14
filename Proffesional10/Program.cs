using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional10
{
    class BaseClass
    {
        protected virtual void DoWork()
        {
            Console.WriteLine("BaseClass");
        }

        public void GetWork()
        {
            DoWork();
        }
    }

    class DerivedClass : BaseClass
    {
        protected override void DoWork()
        {
            Console.WriteLine("DervedClass");
        }
    }

    abstract class MyBaseClass
    {
        protected abstract void Read();
        protected abstract void Write();

        public void ReadWrite()
        {
            Read();
            Write();
        }
    }

    class DerivedClassTXT : MyBaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Reading from a TXT file");
        }

        protected override void Write()
        {
            Console.WriteLine("Write to TXT file");
        }
    }

    class DerivedClassXML : MyBaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Reading from an XML file");
        }

        protected override void Write()
        {
            Console.WriteLine("Writing to an XML File");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new DerivedClass();

            instance.GetWork();

            List<MyBaseClass> collection = new List<MyBaseClass> { new DerivedClassTXT(), new DerivedClassXML() };

            foreach (var item in collection)
            {
                item.ReadWrite();
            }
        }
    }
}
