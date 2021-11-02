using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlAufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"C:\Test\AufgabeXML.xml";
            Menu m1;

            XmlSerializer ser = new XmlSerializer(typeof(Menu));

            using (StreamReader sr = new StreamReader(pfad))
            {
                m1 = (Menu)ser.Deserialize(sr);
                Console.WriteLine("Deserialisierung erfolgreich");
            }

            Console.WriteLine();
            Console.WriteLine(m1);
        }
    }
}
