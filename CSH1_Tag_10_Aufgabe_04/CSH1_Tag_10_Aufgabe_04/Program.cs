using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_10_Aufgabe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fluege anlegen
            Flug.Fluege = new Flug[10]
            {
                new Flug("101", new DateTime(2019,06,12,12,0,0), new DateTime(2019,06,12,18,20,0), 1500, 12),
                new Flug("102", new DateTime(2019,06,12,18,0,0), new DateTime(2019,06,13,0,0,0), 1450, 14),
                new Flug("111", new DateTime(2019,06,12,22,0,0), new DateTime(2019,06,13,4,0,0), 1600, 18),
                new Flug("141", new DateTime(2019,06,13,8,0,0), new DateTime(2019,06,13,14,0,0), 1700, 5),
                new Flug("251", new DateTime(2019,06,13,12,0,0), new DateTime(2019,06,13,18,0,0), 1000, 34),
                new Flug("607", new DateTime(2019,06,13,18,0,0), new DateTime(2019,06,14,0,0,0), 1100, 15),
                new Flug("638", new DateTime(2019,06,14,8,0,0), new DateTime(2019,06,14,14,0,0), 1650, 7),
                new Flug("703", new DateTime(2019,06,14,12,0,0), new DateTime(2019,06,14,18,0,0), 1450, 10),
                new Flug("784", new DateTime(2019,06,14,18,0,0), new DateTime(2019,06,15,0,0,0), 1800, 2),
                new Flug("788", new DateTime(2019,06,14,22,0,0), new DateTime(2019,06,15,4,0,0), 1200, 38),
            };
            #endregion
            foreach (Flug f in Flug.Fluege)
            {
                Console.WriteLine("ID:\t\t"+ f.Id);
                Console.WriteLine("Abflug:\t\t" + f.AbflugZeit.ToString("ddd. dd.MM.yyyy HH:mm"));
                Console.WriteLine("Ankunft:\t" + f.AnkunftZeit.ToString("ddd. dd.MM.yyyy HH:mm"));
                Console.WriteLine("Preis:\t\t" + f.Preis.ToString("0.00"));
                Console.WriteLine("Freie Plätze:\t" + f.FreiePlaetze);
                Console.WriteLine("------------------------------------------\n\n");
            }

            Console.WriteLine("Zeige Flüge 14.06.2019 mit 2 Plätzen");
            foreach (Flug f in Flug.SucheFluege(Convert.ToDateTime("14.06.2019"), 2))
            {
                Console.WriteLine("ID:\t\t" + f.Id);
                Console.WriteLine("Abflug:\t\t" + f.AbflugZeit.ToString("ddd. dd.MM.yyyy HH:mm"));
                Console.WriteLine("Ankunft:\t" + f.AnkunftZeit.ToString("ddd. dd.MM.yyyy HH:mm"));
                Console.WriteLine("Preis:\t\t" + f.Preis.ToString("0.00"));
                Console.WriteLine("Freie Plätze:\t" + f.FreiePlaetze);
                Console.WriteLine("------------------------------------------\n\n");
            }
            Console.ReadKey();
        }
    }
}
