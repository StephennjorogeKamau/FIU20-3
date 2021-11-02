using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonAufgabe4
{
    [DataContract]
    class Rechnung
    {
        //Felder
        [DataMember]
        public int reNr;
        [DataMember]
        public DateTime reDat;
        [DataMember]
        public Kunde kunde;
        [DataMember]
        public List<Produkt> artikel;

        //Konstruktoren
        public Rechnung(int reNr, DateTime reDat, Kunde kunde, List<Produkt> artikel)
        {
            this.reNr = reNr;
            this.reDat = reDat;
            this.kunde = kunde;
            this.artikel = artikel;
        }
        public Rechnung() { }

        //Methoden
        public override string ToString()
        {
            int counter = 1;
            string str = $"Rechungsnummer:\t{reNr}\nDatum:\t\t{reDat.ToShortDateString()}\n\n{kunde}\n\n";

            foreach (Produkt item in artikel)
            {
                if (counter < 10)
                    str += $"0{counter++}.{item}\n\n";
                else
                    str += $"{counter++}.{item}\n\n";
            }

            return str;
        }

        public static void DatenAnlage(string pfad)
        {
            Rechnung r1 = new Rechnung(1234, new DateTime(2021, 4, 12),
                                        new Kunde("Karl", 57, 1.76f, false),
                                        new List<Produkt>());
            r1.artikel.Add(new Produkt("A38", "Passierschein A38", "Das Amt", 1.19f));
            r1.artikel.Add(new Produkt("A39", "Passierschein A39", "Das andere Amt", 2.19f));
            r1.artikel.Add(new Produkt("B38", "Passierschein B38", "Das ganz andere Amt", 3.19f));

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Rechnung));

            using (FileStream fs = new FileStream(pfad, FileMode.Create))
            {
                ser.WriteObject(fs, r1);
            }
        }
    }
}
