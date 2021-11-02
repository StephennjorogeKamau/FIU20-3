using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    static class DasMenu
    {
        public static void Testdaten(ITVerwaltung it)
        {
            it.RechnerHinzu(new Server("DB", "3.3.3.3", 3.8f, 10, 400, 1000, 10, "DB-Server", 10000));
            it.RechnerHinzu(new BueroWorkstation("Sekretär", "1.1.1.1", 2.2f, 4, 500));
            it.RechnerHinzu(new GrafArbeitsplatz("Designer", "2.2.2.2", 3.4f, 16, 1500, 29f, "GeForce 1050 GTX Ti"));
            it.RechnerHinzu(new Server("Server5", "4.4.4.4", 3.8f, 10, 400, 1000, 10, "Server05", 10000));
        }

        public static void Menu(ITVerwaltung it)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(1) Alle Rechner anzeigen");
                Console.WriteLine("(2) Rechner-Kategorie anzeigen");
                Console.WriteLine("(3) Anzahl der gespeicherten Rechner");
                Console.WriteLine("(4) Hinzufügen eines Rechners");
                Console.WriteLine("(5) Löschen eines Rechners");
                Console.WriteLine("(6) Programmende");
                Console.WriteLine();
                Console.Write("Ihre Auswahl: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        it.RechnerAusgeben();
                        break;
                    case "2":
                        SpezielleRechnerAnzeigen(it);
                        break;
                    case "3":
                        //Anzahl
                        break;
                    case "4":
                        Hinzufuegen(it);
                        break;
                    case "5":
                        Loeschen(it);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bitte nur Zahlen von 1-6 eingeben");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Weiter mit beliebiger Taste...");
                Console.ReadKey();
            }
        }
        public static void SpezielleRechnerAnzeigen(ITVerwaltung it)
        {
            Console.Clear();
            Console.WriteLine("(1) Alle Büro-Workstations anzeigen");
            Console.WriteLine("(2) Alle Grafischen Wokstations anzeigen");
            Console.WriteLine("(3) Alle Server anzeigen");
            Console.WriteLine("(4) Alle Terminals anzeigen");
            Console.WriteLine("(5) Zurück");
            Console.WriteLine();
            Console.Write("Ihre Auswahl: ");

            switch (Console.ReadLine())
            {
                case "1":
                    foreach (Rechner item in it.rechnerListe)
                    {
                        if (item is BueroWorkstation && item is not GrafArbeitsplatz)
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            Console.WriteLine();
                        }
                    }
                    break;
                case "2":
                    //Grafisch
                    break;
                case "3":
                    //Server
                    break;
                case "4":
                    //Terminal
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Fehleingabe!");
                    break;
            }
        }
        public static void Hinzufuegen(ITVerwaltung it)
        {
            Console.Clear();
            //Auswahl welcher Rechner

            //Beispiel: Büro-Workstation
            //Console.Write("Name des Rechners eingeben: ");
            //string name = Console.ReadLine();

            //Console.Write("IP-Adresse des Rechners eingeben: ");
            //string ip = Console.ReadLine();

            //Console.Write("Prozessorleistung des Rechners eingeben: ");
            //float proz = float.Parse(Console.ReadLine());

            //Console.Write("RAM-Größe des Rechners eingeben: ");
            //int ram = int.Parse(Console.ReadLine());

            //Console.Write("Größe HDD des Rechners eingeben: ");
            //int hdd = int.Parse(Console.ReadLine());

            //it.RechnerHinzu(new BueroWorkstation(name, ip, proz, ram, hdd));

            //Terminal
            int counter = 0;

            foreach (Rechner item in it.rechnerListe)
            {
                if (item is Server)
                {
                    Console.WriteLine($"{counter}. {item.name}");
                }
                counter++;
            }
            Console.WriteLine();
            Console.Write("Ihre Auswahl: ");
            int index = int.Parse(Console.ReadLine());

            it.RechnerHinzu(new Terminal("Beispiel", "8.8.8.8", "hinten links", (Server)it.rechnerListe[index]));
        }
        public static void Loeschen(ITVerwaltung it)
        {
            Console.Clear();
            int counter = 1;

            //Auswahl
            foreach (Rechner item in it.rechnerListe)
            {
                Console.WriteLine($"({counter}) {item.name}");
                counter++;
            }
            Console.WriteLine();
            Console.Write("Ihre Auswahl: ");

            //Sicherheitsabfrage
            int index;
            bool check;

            do
            {
                check = int.TryParse(Console.ReadLine(), out index);

                if (check == false)
                {
                    Console.WriteLine("Bitte nur Ziffern eingeben!");
                }

                //Fehlend: Eingebene Zahl im Bereich?

            } while (check == false);


            //Löschung
            it.RechnerWeg(it.rechnerListe[index - 1]);
        }
    }
}
