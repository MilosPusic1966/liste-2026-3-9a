using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_3_9a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            // niz
            int[] x;
            x=new int[5];
            int[]b = new int[5];
            // Console.WriteLine(x[4]);

            // matrica
            string[,] y;
            y = new string[3, 4];
            
            // lista
            List<int> z = new List<int>();
            z.Add(5);
            z.Add(10);
            z.Add(20);
            // Console.WriteLine(z[2]);
           
            // stek
            Stack<int> stek = new Stack<int>();
            stek.Push(5);
            stek.Push(10);
            stek.Push(20);
            int s = stek.Pop();
            s = stek.Pop();
            // Console.WriteLine(s);
            // red
            Queue<string> red = new Queue<string>();
            red.Enqueue("Andrej");
            red.Enqueue("Aleksa");
            red.Enqueue("Jaksa");
            string sledeci = red.Dequeue();
            // Console.WriteLine(sledeci);
            sledeci = red.Dequeue();
            // Console.WriteLine(sledeci);

            // lista slogova
            List<grana> grane;
            grane = new List<grana>();
            // jedan slog pravim i popunjavam
            grana nova = new grana();
            nova.cvor = 2;
            nova.tezina = 5;
            // i ubacim u listu
            grane.Add(nova);
            nova = new grana();
            nova.cvor = 3;
            nova.tezina = 1;
            grane.Add(nova);
            nova = new grana();
            nova.cvor = 5;
            nova.tezina = 10;
            grane.Add(nova);
            Console.WriteLine(grane[1].cvor);
            Console.WriteLine(grane[2].tezina);
        }
    }
}
