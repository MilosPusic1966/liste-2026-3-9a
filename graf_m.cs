using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_3_9a
{
    internal class graf_m
    {
        public string[] Cvor;
        public int?[,] matrica;
        public graf_m() { }
        public static graf_m LM(graf stari)
        {
            graf_m novi = new graf_m();
            novi.Cvor = new string[stari.Cvor.Length];
            for (int i = 0; i < stari.Cvor.Length; i++)
            {
                novi.Cvor[i] = stari.Cvor[i];
            }
            novi.matrica = new int?[stari.Cvor.Length, stari.Cvor.Length];
            for (int i = 0; i < stari.Cvor.Length; i++)
            {
                for (int j = 0; j < stari.grane[i].Count; j++)
                {
                    novi.matrica[i, stari.grane[i][j].cvor] = stari.grane[i][j].tezina;
                }
            }
            return novi;
        }
        public static bool usmeren(graf ulaz) { 
            bool rez = true;
            graf_m pomocni = LM(ulaz);
            rez = provera(pomocni);
            return rez;
        }
        public static bool usmeren(graf_m ulaz)
        {
            bool rez = true;
            rez = provera(ulaz);
            return rez;
        }
        public static bool provera(graf_m nesto)
        {
            bool rez = true;
            for (int i = 0; i < nesto.Cvor.Length; i++)
            {
                for (int j = i+1; j < nesto.Cvor.Length; j++)
                {
                    if (nesto.matrica[i, j] != nesto.matrica[j,i])
                    {
                        rez = false;
                        break;
                    }
                }
            }
            return rez;
        }
    }
}
