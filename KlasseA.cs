using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generisch
{
    class KlasseA<T>
    {
        //Felder
        public T obj;
        public int id;

        //Konstruktoren
        public KlasseA(T obj)
        {
            this.obj = obj;
        }
    }
}
