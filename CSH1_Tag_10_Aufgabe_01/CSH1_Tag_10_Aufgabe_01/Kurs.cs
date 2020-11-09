using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_01
{
    class Kurs
    {
        static uint counter = 0;
        public static uint MaxWert = 10;
        static Kurs[] arrKurs = new Kurs[MaxWert];
        int kursnummer;

        public Kurs(int kursnummer)
        {
            bool vorhanden = false;
            foreach(Kurs k in arrKurs)
            {
                if(k != null && k.kursnummer == kursnummer)
                {
                    this.kursnummer = -1;
                    vorhanden = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kursnummer schon vergeben!");
                    Console.ResetColor();
                    break;
                } 
            }
            if(!vorhanden)
            {
                this.kursnummer = kursnummer;
            }
            if(counter < MaxWert)
                arrKurs[counter] = this;
            counter++;
        }

        public static void ZeigeAlle()
        {
            foreach(Kurs k in arrKurs)
            {
                if(k.kursnummer == -1)
                    Console.WriteLine("ERROR: Kursnummer doppelt vergeben");
                else
                    Console.WriteLine(k.kursnummer);
            }
        }
    }
}
