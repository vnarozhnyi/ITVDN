using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proffesional8
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car("Mercedes", 250);

            FileStream stream = File.Create("CarData.data");

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, auto);
            stream.Close();



            Car autos = new Car("Mercedes", 250);

            XmlSerializer serializer = new XmlSerializer(typeof(Car));

            FileStream original = new FileStream("SerializationOriginal.xml", FileMode.Create, FileAccess.Write);

            serializer.Serialize(original, autos);

            original.Close();

            CarXML autoXML = new CarXML("Mercedes", 250);

            XmlSerializer serializerXML = new XmlSerializer(typeof(CarXML));

            FileStream streamXML = new FileStream("SerializationXML.xml", FileMode.Create, FileAccess.Write);

            serializerXML.Serialize(streamXML, autoXML);

            streamXML.Close();


            XmlSerializer serializers = new XmlSerializer(typeof(Car));

            FileStream originals = new FileStream("SerializationOriginal.xml", FileMode.Open, FileAccess.Read);

            Car autoss = (Car)serializer.Deserialize(originals);

            originals.Close();

            Console.WriteLine(autoss.Name + " " + autoss.Speed);

            XmlSerializer serializersXML = new XmlSerializer(typeof(CarXML));

            FileStream streamsXML = new FileStream("SerializationXML.xml", FileMode.Open, FileAccess.Read);

            CarXML autosXML = (CarXML)serializersXML.Deserialize(streamsXML);

            streamsXML.Close();

            Console.WriteLine(autosXML.Name + " " + autosXML.Speed);
        }
    }
}
