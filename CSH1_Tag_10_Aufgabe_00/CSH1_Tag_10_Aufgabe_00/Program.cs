using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Song track1 = new Song("Endlec", "Something more sinister", 358);

            track1.Spielen();
            Console.ReadKey(true);
        }
    }
}
