using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_00
{
    class Song
    {
        string titel, interpret;
        int dauerSekunden;

        public Song(string interpret, string titel, int dauerSekunden)
        {
            this.interpret = interpret;
            this.titel = titel;
            this.dauerSekunden = dauerSekunden;
        }

        public string Titel { get => titel; }
        public string Interpret { get => interpret; }
        public int DauerSekunden { get => dauerSekunden;}

        public void Spielen()
        {
            Console.WriteLine($"Interpret:\t{interpret}");
            Console.WriteLine($"Titel:\t\t{titel}");
            Console.WriteLine($"Dauer:\t\t{dauerSekunden/60:D2}:{dauerSekunden%60:D2}");
        }
    }
}
