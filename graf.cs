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
        public graf() { }
        
        public void Unos()
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
        public void Ispis() { 
            for (int i = 0; i < Cvor.Length; i++)
            {
                Console.WriteLine($"Cvor {i} {Cvor[i]}");
                foreach (grana g in grane[i])
                {
                    Console.WriteLine($"Sused {g.cvor} Tezina {g.tezina}");
                }
            }
        }
        public void Snimi() { 
            System.IO.StreamWriter sw = new System.IO.StreamWriter("graf.txt");
            sw.WriteLine(Cvor.Length);
            for (int i = 0; i < Cvor.Length; i++)
            {
                sw.WriteLine(Cvor[i]);
            }
            for (int i = 0; i < Cvor.Length; i++)
            {
                foreach (grana g in grane[i])
                {
                    sw.WriteLine($"{g.cvor}");
                    sw.WriteLine($"{g.tezina}");
                }
                sw.WriteLine("-1");
            }
            sw.Close();
        }
        public void Ucitaj() { 
            System.IO.StreamReader sr = new System.IO.StreamReader("graf.txt");
            int n = Convert.ToInt32(sr.ReadLine());
            Cvor = new string[n];
            for (int i = 0; i < n; i++)
            {
                Cvor[i] = sr.ReadLine();
            }
            grane = new List<grana>[n];
            for (int i = 0; i < n; i++)
            {
                grane[i] = new List<grana>();
                int sused = Convert.ToInt32(sr.ReadLine());
                while (sused != -1)
                {
                    grana Nova = new grana();
                    Nova.cvor = sused;
                    Nova.tezina = Convert.ToInt32(sr.ReadLine());
                    grane[i].Add(Nova);
                    sused = Convert.ToInt32(sr.ReadLine());
                }
            }
            sr.Close();
        }
    }
}
