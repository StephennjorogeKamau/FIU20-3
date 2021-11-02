using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonAufgabe1
{
    [DataContract]
    class Text
    {
        //Felder
        [DataMember]
        public string data;
        [DataMember]
        public int size;
        [DataMember]
        public string style;
        [DataMember]
        public string name;
        [DataMember]
        public int hOffset;
        [DataMember]
        public int vOffset;
        [DataMember]
        public string alignment;
        [DataMember]
        public string onMouseUp;

        //Methoden
        public override string ToString()
        {
            return $"Data: {data}\nSize: {size}\nStyle: {style}\nName: {name}\n" +
                $"hOffset: {hOffset}\nvOffset: {vOffset}\nAlignment: {alignment}\n" +
                $"OnMouseUp: {onMouseUp}";
        }
    }
}
