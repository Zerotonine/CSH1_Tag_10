using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_02
{
    class MeinRandom
    {
        static Random rnd = new Random();

        public int MeinNext(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        public double MeinNextDouble(double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }

        public char MeinNextChar(char min, char max)
        {
            return (char)rnd.Next(min, max);
        }
    }
}
