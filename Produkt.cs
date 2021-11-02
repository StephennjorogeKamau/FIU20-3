using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonAufgabe4
{
    [DataContract]
    class Produkt
    {
        //Felder
        [DataMember]
        public string id;
        [DataMember]
        public string beschreibung;
        [DataMember]
        public string hersteller;
        [DataMember]
        public float preis;

        //Konstruktoren
        public Produkt(string id, string beschreibung, string hersteller, float preis)
        {
            this.id = id;
            this.beschreibung = beschreibung;
            this.hersteller = hersteller;
            this.preis = preis;
        }
        public Produkt() { }

        //Methoden
        public override string ToString()
        {
            return $"Produkt:\n------------\nID:\t\t{id}\nBeschreibung:\t{beschreibung}\n" +
                $"Hersteller:\t{hersteller}\nPreis:\t\t{preis} Euro";
        }
    }
}
