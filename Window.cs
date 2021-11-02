using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonAufgabe1
{
    [DataContract]
    class Window
    {
        //Felder
        [DataMember]
        public string title;
        [DataMember]
        public string name;
        [DataMember]
        public int width;
        [DataMember]
        public int height;

        //Methoden
        public override string ToString()
        {
            return $"Title: {title}\nName: {name}\nWidth: {width}\nHeight: {height}";
        }
    }
}
