using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung_Json
{
    [DataContract]
    class Vip
    {
        //Felder
        [DataMember]
        internal string name;
        [DataMember]
        public int alter;
        [DataMember]
        public Adresse adr;

        //Konstruktoren
        public Vip(string name, int alter, Adresse adr)
        {
            this.name = name;
            this.alter = alter;
            this.adr = adr;
        }

        public Vip() { }

        //Methoden
        public override string ToString()
        {
            return $"Name: {name}\nAlter: {alter}\n{adr}";
        }
    }
}
