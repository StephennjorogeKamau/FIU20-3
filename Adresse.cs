using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialisierung_XML
{
    public class Adresse
    {
        public string strasse;
        public string hausNr;
        [XmlAttribute]
        public string plz;
        public string ort;

        public Adresse(string strasse, string hausNr, string plz, string ort)
        {
            this.strasse = strasse;
            this.hausNr = hausNr;
            this.plz = plz;
            this.ort = ort;
        }
        public Adresse() { }

        public override string ToString()
        {
            return $"{strasse} {hausNr}\n{plz} {ort}";
        }
    }
}
