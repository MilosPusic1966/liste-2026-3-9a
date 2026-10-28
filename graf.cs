using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_3_9a
{
    internal class graf
    {
        public string[] Cvor;
        public List<grana>[] grane;
        public graf()
        {
            Console.WriteLine("Unesite broj cvorova");
            int n = Convert.ToInt32(Console.ReadLine());
            Cvor = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Unesite ime cvora");
                Cvor[i] = Console.ReadLine();
            }
            grane = new List<grana>[n];
            for (int i = 0; i < n; i++)
            {
                grane[i] = new List<grana>();
                Console.WriteLine($"Sused cvora {i}");
                int sused = Convert.ToInt32(Console.ReadLine());
                while (sused != -1)
                {
                    grana Nova = new grana();
                    Nova.cvor = sused;
                    Console.WriteLine("Unesite tezinu");
                    int tezina = Convert.ToInt32(Console.ReadLine());
                    Nova.tezina = tezina;
                    grane[i].Add(Nova);
                    Console.WriteLine($"Sused cvora {i}");
                    sused = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
