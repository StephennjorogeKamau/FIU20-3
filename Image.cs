using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlAufgabe3
{
    public class Image
    {
        [XmlAttribute]
        public string src;
        [XmlAttribute]
        public string name;
        public int hOffset;
        public int vOffset;
        public string alignment;

        public override string ToString()
        {
            return $"{src}\n{name}\n{hOffset}\n{vOffset}\n{alignment}";
        }
    }
}
