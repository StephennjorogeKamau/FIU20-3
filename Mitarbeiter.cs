using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Mitarbeiter : Person
    {
        //Felder
        public int persNr;

        //Methoden
        public override string ToString()
        {
            return base.ToString() + $"\nPersonalnummer: {persNr}";
        }
    }
}
