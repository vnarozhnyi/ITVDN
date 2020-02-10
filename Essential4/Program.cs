using Essential4.Essential4_1;
using Essential4.Essential4_2;
using Essential4.Essential4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4
{
    class Program
    {
        static void Main(string[] args)
        {
            Documents document = new Documents("Contract");
            document.Body = "Contract body...";
            document.Footer = "Director: I. Ivanov";

            document.Show();


            Console.WriteLine(new string('-', 50));


            Redactor redactor = new Redactor();
            redactor.ChooseDocument("file.txt");

            redactor.Open();
            redactor.Change();
            redactor.Save();


            Console.WriteLine(new string('-', 50));


            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();

            Console.ReadKey();
        }
    }
}
