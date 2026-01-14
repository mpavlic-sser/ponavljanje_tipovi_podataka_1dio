using System;

namespace CSharpOsnove
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("C# OSNOVE — IZBORNIK ZADATAKA");
                Console.WriteLine("1) Pogodi tip (tipovi podataka)");
                Console.WriteLine("2) Chat bot za upis u školu");
                Console.WriteLine("3) RGB provjera");
                Console.WriteLine("4) Temperatura učionice (float vs double)");
                Console.WriteLine("0) Izlaz");
                Console.WriteLine("====================================");
                Console.Write("Odaberi zadatak: ");

                string? izbor = Console.ReadLine();
                Console.WriteLine();

                switch (izbor)
                {
                    case "1":
                        Zadatak1_PogodiTip.Izvrsi();
                        break;
                    case "2":
                        Zadatak2_ChatBot.Izvrsi();
                        break;
                    case "3":
                        Zadatak3_RgbProvjera.Izvrsi();                       
                        break;
                    case "4":
                        Zadatak4_Temperatura.Izvrsi();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Nepoznat odabir. Pokušaj ponovno.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Pritisni ENTER za povratak na izbornik...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
