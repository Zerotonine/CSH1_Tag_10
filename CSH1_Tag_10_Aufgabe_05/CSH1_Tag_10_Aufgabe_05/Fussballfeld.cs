using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_05
{
    class Fussballfeld
    {
        int breite, laenge;
        bool dfbtauglich;

        public Fussballfeld(int breite, int laenge)
        {
            this.breite = breite;
            this.laenge = laenge;
            if (breite <= 55 && breite >= 45 && laenge <= 110 && laenge >= 90)
                this.dfbtauglich = true;
        }

        public void zeigeAlle()
        {
            Console.WriteLine("Breite:\t" + breite);
            Console.WriteLine("Länge:\t" + laenge);
            Console.WriteLine("DFB:\t" + dfbtauglich);
        }
    }
}
