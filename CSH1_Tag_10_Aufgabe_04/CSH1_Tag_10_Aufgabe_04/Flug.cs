using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_04
{
    class Flug
    {
        public static Flug[] Fluege;
        public string Id { get; }
        public int FreiePlaetze{ get; }
        public DateTime AbflugZeit { get; }
        public DateTime AnkunftZeit { get; }
        public double Preis { get; }

        public Flug(string id, DateTime abflugZeit, DateTime ankunftZeit, double preis, int freiePlaetze)
        {
            this.Id = id;
            this.AbflugZeit = abflugZeit;
            this.AnkunftZeit = ankunftZeit;
            this.Preis = preis;
            this.FreiePlaetze = freiePlaetze;
        }

        static public Flug[] SucheFluege(DateTime abflug, int plaetze)
        {
            
            return Array.FindAll(Fluege, f => f.AbflugZeit.Date == abflug.Date && f.FreiePlaetze >= plaetze).OrderBy(f=>f.Preis).ToArray();
        }
    }
}
