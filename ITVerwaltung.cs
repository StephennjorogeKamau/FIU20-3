using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class ITVerwaltung
    {
        //Felder
        public List<Rechner> rechnerListe = new List<Rechner>();
        public int counter = 0;

        //Methoden
        public void RechnerAusgeben()
        {
            foreach (Rechner item in rechnerListe)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
        public void RechnerHinzu(Rechner r)
        {
            rechnerListe.Add(r);
            counter++;
        }
        public void RechnerWeg(Rechner r)
        {
            rechnerListe.Remove(r);
            counter--;
        }
    }
}
