using System;

namespace CSharpOsnove
{
    internal static class Zadatak2_ChatBot
    {
        public static void Izvrsi()
        {
            Console.WriteLine("ZADATAK 2 — Chat bot za upis u školu");
            Console.WriteLine("-----------------------------------");

            // TODO 1: Traži od korisnika: ime (string)
            Console.Write("Unesi ime: ");
            string ime = Console.ReadLine() ?? "";

            // TODO 2: Traži od korisnika: prezime (string)
            Console.Write("Unesi prezime: ");
            string prezime = Console.ReadLine() ?? "";

            // TODO 3: Traži od korisnika: razred (byte)
            Console.Write("Unesi razred (1-4): ");
            byte razred = byte.Parse(Console.ReadLine() ?? "0");

            // TODO 4: Traži od korisnika: smjer (string)
            Console.Write("Unesi smjer: ");
            string smjer = Console.ReadLine() ?? "";

            Console.WriteLine();

            // TODO 5: Ispiši poruku koristeći string interpolaciju ($"...")
            // Primjer: Učenik Ivan Horvat pohađa 2. razred smjera Tehničar za računalstvo.
            Console.WriteLine("TODO: Ovdje ispiši poruku koristeći STRING INTERPOLACIJU.");

            // TODO 6: Ispiši ISTU poruku koristeći String.Format()
            Console.WriteLine("TODO: Ovdje ispiši poruku koristeći String.Format().");
        }
    }
}
