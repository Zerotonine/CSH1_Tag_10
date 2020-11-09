using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            MeinRandom mrnd = new MeinRandom();
            ConsoleKey ck = new ConsoleKey();

            while(ck != ConsoleKey.Escape)
            {
                if (Console.KeyAvailable)
                    ck = Console.ReadKey(true).Key;

                Thread.Sleep(300);
                if(ck == ConsoleKey.I)
                {
                    rndInt(mrnd);
                }
                if(ck == ConsoleKey.D)
                {
                    rndDbl(mrnd);
                }
                if(ck ==ConsoleKey.C)
                {
                    rndChr(mrnd);
                }
            }

            Console.ReadKey();
        }

        static void rndInt(in MeinRandom mrnd)
        {
            Console.WriteLine($"RND int:\t{mrnd.MeinNext(0, 20)}");
        }
        static void rndDbl(in MeinRandom mrnd)
        {
            Console.WriteLine($"RND dbl:\t{mrnd.MeinNextDouble(0.2, 0.5):0.00}");
        }
        static void rndChr(in MeinRandom mrnd)
        {
            Console.WriteLine($"RND char:\t{mrnd.MeinNextChar('D', 'X')}");
        }
    }
}
