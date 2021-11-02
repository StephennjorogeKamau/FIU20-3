using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    class Terminal : Rechner
    {
        //Felder
        public string standort;
        public Server referenz;

        public Terminal(string name, string ip, string standort, Server referenz) : base(name, ip)
        {
            this.standort = standort;
            this.referenz = referenz;
        }

        //Methoden
        public override string ToString()
        {
            return base.ToString() + $"\nStandort {standort}\nServer: {referenz.name}";
        }
    }
}
