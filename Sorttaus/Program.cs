using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorttaus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Jono = new int[3];
            int[] Result = new int[3];
            int Dummy;
            bool Tulos;
            bool Pienin;

            for (int Count = 0; Count < 3; Count++)
            {
                Tulos = true;
                Console.Write("Anna luku: ");
                Tulos = int.TryParse(Console.ReadLine(), out Jono[Count]);
                if (!Tulos)
                {
                    Console.WriteLine("Et antanut lukua! Yritä uudestaan!");
                    Count = Count - 1;
                }
            }

            Array.Sort(Jono);

            Console.WriteLine("Luvut ovat " + Jono[0] + ", " + Jono[1] + ", " + Jono[2] + " nousevassa järjestyksessä.");
            Console.ReadKey();
            
        }
    }
}
