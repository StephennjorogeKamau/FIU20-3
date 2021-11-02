using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenschaften
{
    class PKW
    {
        public string hersteller;
        public string modell;
        public string farbe;

        private int aktGeschw;
        public int AktGeschw
        {
            get
            {
                return aktGeschw * 100;
            }
            set
            {
                if (value > 80)
                    aktGeschw = 80;
                else
                    aktGeschw = value;
            }
        }

        public int MaxGeschw { get; set; }


        public PKW(string hersteller, string modell, string farbe, int aktGeschw)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.farbe = farbe;
            this.aktGeschw = aktGeschw;
        }

        public void Beschleunigen(int wert)
        {
            aktGeschw += wert;
        }
        public void Bremsen(int wert)
        {
            aktGeschw -= wert;
        }
    }
}
