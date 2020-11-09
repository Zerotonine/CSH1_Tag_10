using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fussballfeld> flist = new List<Fussballfeld>()
            {
                new Fussballfeld(30, 100),
                new Fussballfeld(50, 100),
                new Fussballfeld(50, 120),
                new Fussballfeld(50, 89),
            };

            foreach(Fussballfeld f in flist)
            {
                f.zeigeAlle();
                Console.WriteLine("-------------------------\n");
            }
            Console.ReadKey();
        }
    }
}
