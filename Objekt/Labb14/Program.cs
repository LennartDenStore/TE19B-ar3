using System;

namespace Labb14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter boken? ");
            string titel = Console.ReadLine();
            Console.WriteLine("Vad heter Förfataren? ");
            string författare = Console.ReadLine();
            Console.WriteLine("Ange antal sidor ");
            int antalSidor = int.Parse(Console.ReadLine());

            // Skapa ett objekt = bok av typen Bok
            // bok heter också instans av Bok
            Bok bok = new Bok(titel, författare, antalSidor);

            // skriv ut samanfatning
            bok.skrivut();
        }
    }
}
