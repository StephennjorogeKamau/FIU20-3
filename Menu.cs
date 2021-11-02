using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlAufgabe1
{
    [XmlRoot("menu")]
    public class Menu
    {
        [XmlAttribute]
        public string id;
        [XmlAttribute]
        public string value;
        public List<menuitem> popup;


        public override string ToString()
        {
            string str = $"{id}\n{value}";

            foreach (menuitem item in popup)
                str += "\n" + item;

            return str;
        }
    }
}
