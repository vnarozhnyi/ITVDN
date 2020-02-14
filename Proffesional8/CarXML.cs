using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proffesional8
{
    public class CarXML
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public int Speed { get; set; }

        public CarXML(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public CarXML()
        {

        }
    }
}
