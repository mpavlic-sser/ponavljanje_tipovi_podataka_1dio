using System;

namespace CSharpOsnove
{
    internal static class Zadatak4_Temperatura
    {
        public static void Izvrsi()
        {
            Console.WriteLine("ZADATAK 4 — Temperatura učionice (float vs double)");
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Unesi temperaturu (npr. 21.5): ");
            string unos = Console.ReadLine() ?? "0";

            // TODO 1: Spremi unos u float i ispiši: Temperatura (float): ...
            // Napomena: float se najčešće parsira iz stringa.
            float temperaturaFloat = float.Parse(unos);

            // TODO 2: Spremi unos u double i ispiši: Temperatura (double): ...
            double temperaturaDouble = double.Parse(unos);

            Console.WriteLine("TODO: Ovdje ispiši temperaturu (float).");
            Console.WriteLine("TODO: Ovdje ispiši temperaturu (double).");
        }
    }
}
