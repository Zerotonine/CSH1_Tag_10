using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_03
{
    class Ritter
    {
        public static List<Ritter> listRitter = new List<Ritter>();
        public string Name;
        public Pferd SeinPferd;

        public Ritter()
        {
            Pferd p = new Pferd();
            p.Besitzer = this;
            SeinPferd = p;
            listRitter.Add(this);
            Pferd.listPferd.Add(p);
        }

        public Ritter(string nameRitter, string namePferd)
        {
            Pferd p = new Pferd();
            p.Besitzer = this;
            p.Name = namePferd;
            this.Name = nameRitter;
            SeinPferd = p;
            listRitter.Add(this);
            Pferd.listPferd.Add(p);
        }
    }
}
