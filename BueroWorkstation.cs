using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class BueroWorkstation : Rechner
    {
        //Felder
        public float prozLeistung;
        public int ram;
        public int groesseHDD;

        //Konstruktor
        public BueroWorkstation(string name, string ip, float prozLeistung, int ram, int groesseHDD)
            : base(name, ip)
        {
            this.prozLeistung = prozLeistung;
            this.ram = ram;
            this.groesseHDD = groesseHDD;
        }

        //Methoden
        public override string ToString()
        {
            return base.ToString() + $"\nProzessor Leistung: {prozLeistung}\nRAM: {ram}\nGröße HDD: {groesseHDD}";
        }
    }
}
