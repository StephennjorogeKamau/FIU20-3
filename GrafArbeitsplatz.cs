using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class GrafArbeitsplatz : BueroWorkstation
    {
        //Felder
        public string modellGraka;
        public float groesseMonitor;

        //Konstruktor
        public GrafArbeitsplatz(string name, string ip, float prozLeistung, int ram, int groesseHDD,
            float groesseMonitor, string modellGraka) : base(name, ip, prozLeistung, ram, groesseHDD)
        {
            this.groesseMonitor = groesseMonitor;
            this.modellGraka = modellGraka;
        }

        //Methoden
        public override string ToString()
        {
            return base.ToString() + $"\nMonitorgröße: {groesseMonitor}\nGrafikkarte: {modellGraka}";
        }
    }
}
