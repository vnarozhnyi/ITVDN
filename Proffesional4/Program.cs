using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proffesional4
{
    class Program
    {
        static void Main(string[] args)
        {
            string petternLogin = @"^[A-Za-z]+$";
            string petternPassword = @"^[A-Za-z0-9\S]+$";

            Console.Write("Enter login: ");
            string login = Console.ReadLine();

            if (!Regex.IsMatch(login, petternLogin))
            {
                Console.WriteLine("You have entered a login that does not match the template!");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (!Regex.IsMatch(password, petternPassword))
            {
                Console.WriteLine("You have entered a login that does not match the template!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("You are registered!");


            Console.WriteLine(new string('_', 50));


            Console.Write("Enter the site address to check: ");
            string url = Console.ReadLine();

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

            StreamWriter writer = File.CreateText("Log.txt");

            var regex = new Regex(@"href='(?<link>\S+)'>");

            foreach (Match m in regex.Matches(responseFromServer))
            {
                writer.WriteLine("LINK: {0,-25}", m.Groups["link"]);
            }

            regex = new Regex(@"(?<phone>[+3(0-90-90-9)\s]{2,}[0-9]{3}[\s\-][0-9]{2}[\s\-][0-9]{2})");

            foreach (Match m in regex.Matches(responseFromServer))
            {
                writer.WriteLine("Phone number: {0,-25}", m.Groups["phone"]);
            }

            regex = new Regex(@"(?<email>[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4})");

            foreach (Match m in regex.Matches(responseFromServer))
            {
                writer.WriteLine("E-Mail: {0,-25}", m.Groups["email"]);
            }

            writer.Close();


            Console.WriteLine(new string('_', 50));


            string sentence = File.ReadAllText("text.txt", Encoding.Default);

            Console.WriteLine(sentence);

            Console.WriteLine(new string('-', 80));

            string pattern = @"\s[а-я]{1,3}\s";

            string sentenceNew = Regex.Replace(sentence, pattern, " ГАВ! ");

            Console.WriteLine(sentenceNew);

            File.WriteAllText("text_New.txt", sentenceNew, Encoding.Default);


            Console.WriteLine(new string('_', 50));


            var my = CultureInfo.CurrentCulture;
            var ua = new CultureInfo("uk-UA");

            string sentences = File.ReadAllText("product.txt", Encoding.Default);

            Console.WriteLine(sentences);

            Console.WriteLine(new string('-', 25));

            string patterns = @"[0-9]+[\.\,][0-9]+";

            string sentenceMy = Regex.Replace(sentences, patterns, (m) => double.Parse(m.Value).ToString("C", my));
            string sentenceUa = Regex.Replace(sentences, patterns, (m) => double.Parse(m.Value).ToString("C", ua));

            Console.WriteLine(sentenceMy);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine(sentenceUa);

            Console.ReadKey();
        }
    }
}
