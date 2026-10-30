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
            graf Prvi=null;
            while (izbor != 0)
            {
                Console.WriteLine("1. Unos ");
                Console.WriteLine("2. Stampa ");
                Console.WriteLine("3. Snimi ");
                Console.WriteLine("4. Ucitaj ");
                Console.WriteLine("5. L->M ");
                Console.WriteLine("6. M->L ");
                Console.WriteLine("7. Usmeren ");
                Console.WriteLine("0. Kraj ");
                izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Prvi = new graf();
                        Prvi.Unos();
                        break;
                    case 2:
                        Prvi.Ispis();
                        break;
                    case 3:
                        Prvi.Snimi();
                        break;
                    case 4:
                        Prvi = new graf();
                        Prvi.Ucitaj();
                        break;
                        case 5:
                            graf_m Drugi = graf_m.LM(Prvi);
                        break;
                    case 7:
                        if (graf_m.usmeren(Prvi)) Console.WriteLine("Nije usmeren ");
                        else Console.WriteLine("Jeste usmeren");
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
