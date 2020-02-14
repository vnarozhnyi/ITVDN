using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\");

            dir.CreateSubdirectory("TestDir");

            for (int i = 0; i < 100; i++)
            {
                dir.CreateSubdirectory(string.Format(@"TestDir\Folder_{0}", i));
            }

            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(string.Format(@"D:\TestDir\Folder_{0}", i));
            }


            Console.WriteLine(new string('_', 50));


            StreamWriter writer = File.CreateText("test.txt");
            writer.WriteLine("Hello world!!!");
            writer.Close();

            StreamReader reader = File.OpenText("test.txt");
            string text = reader.ReadToEnd();
            Console.WriteLine(text);


            Console.ReadKey();


        }
    }
}
