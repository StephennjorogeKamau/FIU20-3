using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitten
{
    class Kunde
    {
        public string vorname;
        public string nachname;
        public int alter;

        public Kunde(string vorname, string nachname, int alter)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
        }
    }
}
