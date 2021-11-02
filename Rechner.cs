using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class Rechner
    {
        //Felder
        public string name;
        public string ip;

        //Konstruktor
        public Rechner(string name, string ip)
        {
            this.name = name;
            this.ip = ip;
        }

        //Methoden
        public override string ToString()
        {
            return $"Name: {name}\nIP: {ip}";
        }
    }
}
