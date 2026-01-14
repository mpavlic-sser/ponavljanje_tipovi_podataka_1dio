using System;

namespace CSharpOsnove
{
    internal static class Zadatak2_RgbProvjera
    {
        public static void Izvrsi()
        {
            Console.WriteLine("ZADATAK 2 — RGB provjera");
            Console.WriteLine("------------------------");

            // TODO 1: Učitaj R, G, B (0–255). Spremi ih u byte.
            // Napomena: Unos je tekst pa se čita s Console.ReadLine().

            Console.Write("Unesi R (0-255): ");
            int rUnos = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Unesi G (0-255): ");
            int gUnos = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Unesi B (0-255): ");
            int bUnos = int.Parse(Console.ReadLine() ?? "0");

            // TODO 2: Ako je bilo koja vrijednost izvan raspona 0–255, ispiši:
            // "Neispravan unos za RGB!" i završi zadatak (return).
            if (rUnos < 0 || rUnos > 255 || gUnos < 0 || gUnos > 255 || bUnos < 0 || bUnos > 255)
            {
                Console.WriteLine("Neispravan unos za RGB!");
                return;
            }

            // TODO 3: Tek nakon provjere pretvori u byte (i spremi u varijable r, g, b).
            byte r = (byte)rUnos;
            byte g = (byte)gUnos;
            byte b = (byte)bUnos;

            // TODO 4: Ispiši boju u obliku: RGB(255, 128, 64)
            Console.WriteLine("TODO: Ovdje ispiši RGB(r, g, b).");
        }
    }
}
