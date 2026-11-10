using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
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
        public int povezan() { 
            int KP = 0;
            Queue<int> Red = new Queue<int>();
            int[] P = new int[Cvor.Length];
            for (int i = 0; i < Cvor.Length; i++)
            {
                P[i] = 0;
            }
            for(int i=0; i < Cvor.Length; i++)
            {
                if (P[i] == 0) {
                    KP++;
                    Red.Enqueue(i);
                    while (Red.Count > 0)
                    {
                        int sled = Red.Dequeue();
                        foreach (grana g in grane[sled])
                        {
                            if (P[g.cvor] == 0)
                            {
                                Red.Enqueue(g.cvor);
                            }
                            P[g.cvor] = KP;
                        }
                    }
                }
            }
            return KP;
        }
        public string BF(int poc) { 
            string rez = "";
            int[] T = new int[Cvor.Length];
            for (int i = 0; i < Cvor.Length; i++)
            {
                T[i] = 99;
            }
            T[poc] = 0;
            List<grana_t> grane_t = new List<grana_t>();
            for (int i=0; i < Cvor.Length; i++)
            {
                foreach (grana g in grane[i])
                {
                    grana_t Nova = new grana_t();
                    Nova.from = i;
                    Nova.to = g.cvor;
                    Nova.w = g.tezina;
                    grane_t.Add(Nova);
                }
            }
            int iter = 0;
            while (iter < Cvor.Length)
            {
                int bilo = 0;
                for (int i =0;i<grane_t.Count;i++)
                {
                    if (T[grane_t[i].from] + grane_t[i].w < T[grane_t[i].to])
                    {
                        T[grane_t[i].to] = T[grane_t[i].from] + grane_t[i].w;
                        bilo = 1;
                    }
                }
                if (bilo == 0) break;
                iter++;
            }
            if(iter == Cvor.Length)
            {
                rez = "Postoji negativan ciklus";
            }
            else
            {
                for (int i = 0; i < Cvor.Length; i++)
                {
                    rez += $"Cvor {i} {Cvor[i]} Tezina {T[i]}\n";
                }
            }
            // ispis rezultata
            return rez;
        }
    }
}
