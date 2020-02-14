using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Proffesional5
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("(093)*******");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Alex Alexeev");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            FileStream streams = new FileStream("TelephoneBook.xml", FileMode.Open);

            XmlTextReader xmlReaders = new XmlTextReader(streams);

            while (xmlReaders.Read())
            {
                if (xmlReaders.HasAttributes)
                {
                    if (xmlReaders.Name.Equals("Contact"))
                    {
                        Console.WriteLine("<{0}>", xmlReaders.GetAttribute("TelephoneNumber"));
                    }
                }
            }

            //xmlReader.Close();

            Console.WriteLine(new string('_', 50));


            FileStream stream = new FileStream("TelephoneBook.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}",
                    xmlReader.NodeType,
                    xmlReader.Name,
                    xmlReader.Value);
            }

            xmlReader.Close();
        }
    }
}
