using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverek
{
    class Program
    {


        enum fegyver { pisztoly, bfg9000, m4a1, ágyú }

        const int maxPisztoly = 100;
        const int maxBfg = 50;
        const int maxM4a1 = 700;
        const int maxÁgyú = 10;
        struct Fegyver
        {
            public fegyver név;
            public int töltény;
        }

        static void Main(string[] args)
        {


            List<Fegyver> inventory = new List<Fegyver>();
            Fegyver énFegyverem = new Fegyver();
            énFegyverem.név = fegyver.ágyú;
            énFegyverem.töltény = 5;


            Betáraz(inventory);
            Kilistáz(inventory);
            int db = Csekkol(inventory, fegyver.ágyú);  //Egy adott fegyverben hány töltény van.
            Felvesz(inventory, fegyver.ágyú);
            Eldob(inventory);




            Console.ReadKey();
        }

        private static void Felvesz(List<Fegyver> inventory, fegyver fegy)
        {
            //Eldöntés tétel
            bool van = false;
            int i = 0;
            foreach (Fegyver f in inventory)
            {
                if (f.név == fegy)
                {
                    van = true;
                    break;
                }
                i++;
            }
            if (van)
            {

            }

        }

        private static int Csekkol(List<Fegyver> inventory, fegyver.aktFegyver)
        {
            int i = 0;
            while (inventory[i].név != ágyú)
            {
                i++;
            }
            return inventory[i].töltény;
        }

        private static void Kilistáz(List<Fegyver> inventory)
        {
            foreach (Fegyver fegy in inventory)
            {
                Console.WriteLine($"{fegy.név}: {fegy.töltény}");
            }
        }

        private static void Betáraz(List<Fegyver> inventory)
        {
            Fegyver f = new Fegyver();
            f.név = fegyver.pisztoly;
            f.töltény = maxPisztoly;
            inventory.Add(f);

            Fegyver f1 = new Fegyver();
            f1.név = fegyver.bfg9000;
            f1.töltény = maxBfg;
            inventory.Add(f1);

            Fegyver f2 = new Fegyver();
            f2.név = fegyver.m4a1;
            f2.töltény = maxM4a1;
            inventory.Add(f2);

            Fegyver f3 = new Fegyver();
            f3.név = fegyver.ágyú;
            f3.töltény = maxÁgyú;
            inventory.Add(f3);
        }
    }
}
