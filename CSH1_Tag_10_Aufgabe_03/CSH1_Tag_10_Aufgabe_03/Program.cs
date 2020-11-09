using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ritter r1 = new Ritter();
            r1.Name = "Graf von Holzhausen";
            r1.SeinPferd.Name = "Lucy";

            Ritter r2 = new Ritter("Prinz von Doppelkeks", "Schoko");

            Console.WriteLine("Ausgabe Ritterliste\n");
            foreach(Ritter r in Ritter.listRitter)
            {
                Console.WriteLine($"Rittername:\t{r.Name}");
                Console.WriteLine($"Pferdename:\t{r.SeinPferd.Name}");
                Console.WriteLine("--------------------------------------\n");
            }

            Console.WriteLine("\n\nAusgabe Pferdeliste\n");
            foreach(Pferd p in Pferd.listPferd)
            {
                Console.WriteLine($"Pferdename:\t{p.Name}");
                Console.WriteLine($"Besitzername:\t{p.Besitzer.Name}");
                Console.WriteLine("--------------------------------------\n");
            }
            Console.ReadKey();
        }
    }
}
