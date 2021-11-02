using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class Server : Rechner
    {
        //Felder
        public float prozLeistung;
        public int prozAnzahl;
        public int ram;
        public int groesseHDD;
        public int anzahlHDD;
        public string funktion;
        public int leistungNetz;

        //Konstruktor
        public Server(string name, string ip, float prozLeistung, int prozAnzahl, int ram, int groesseHDD,
            int anzahlHDD, string funktion, int leistungNetz) : base(name, ip)
        {
            this.prozLeistung = prozLeistung;
            this.prozAnzahl = prozAnzahl;
            this.ram = ram;
            this.groesseHDD = groesseHDD;
            this.anzahlHDD = anzahlHDD;
            this.funktion = funktion;
            this.leistungNetz = leistungNetz;
        }

        //Methoden
        public override string ToString()
        {
            return base.ToString() + $"\nProzessor Leistung: {prozLeistung}" +
                $"\nAnzahl der Prozessoren: {prozAnzahl}" + 
                $"\nRAM: {ram}" +
                $"\nGröße HDD: {groesseHDD}" +
                $"\nAnzahl HDD: {anzahlHDD}" + 
                $"\nFunktion des Servers: {funktion}" +
                $"\nLeistung Netz: {leistungNetz}";
        }
    }
}
