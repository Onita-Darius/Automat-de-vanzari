using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_de_vanzari
{
    internal class Program
    {
        static void Main()
        {
            int Bani = 0;
            string In, x = "y";
            while (x == "y")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"--Bani in aparat: {Bani}--");
                Console.ResetColor();
                while (Bani < 20)
                {
                    Console.WriteLine($"Introdu o moneda (Q, D, N)");
                    In = Console.ReadLine();
                    if (In == "q" || In == "Q") Bani = Bani + 25;
                    else if (In == "d" || In == "D") Bani = Bani + 10;
                    else if (In == "n" || In == "N") Bani = Bani + 5;
                    else Console.WriteLine($"{In} nu este o moneda acceotata");
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"--Bani in aparat: {Bani}--");
                    Console.ResetColor();
                }
                if (Bani >= 20)
                {
                    Console.WriteLine("Produs dispensat");
                    Bani = Bani - 20;
                    Console.WriteLine($"Rest {Bani}");
                }
                Console.WriteLine("Doresti alt produs? (y, n)");
                x = Console.ReadLine();
                if (x != "y") Console.WriteLine($"Rest dispensat ({Bani})");
            }
        }
    }
}
