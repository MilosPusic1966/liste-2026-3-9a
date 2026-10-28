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
            int izbor = 1;
            while (izbor != 0)
            {
                Console.WriteLine("1. Unos ");
                Console.WriteLine("2. Stampa ");
                Console.WriteLine("3. Snimi ");
                Console.WriteLine("4. Ucitaj ");
                Console.WriteLine("0. Kraj ");
                izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Unos");
                        break;
                    case 2:
                        Console.WriteLine("Stampa");
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
