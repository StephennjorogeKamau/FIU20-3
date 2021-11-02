using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlAufgabe1
{
    public class menuitem
    {
        [XmlAttribute]
        public string value;
        [XmlAttribute]
        public string onclick;

        public override string ToString()
        {
            return $"{value}\n{onclick}";
        }
    }
}
