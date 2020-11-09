using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for(int i = 0; i < Kurs.MaxWert; i++)
            {
                Kurs k = new Kurs(rnd.Next(1, (int)Kurs.MaxWert + 1));
            }

            Console.WriteLine("-------------------------------\n\n");

            Kurs.ZeigeAlle();

            Console.ReadKey();
        }
    }
}
