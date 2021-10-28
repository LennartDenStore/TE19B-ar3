using System;
using System.Collections.Generic;

namespace Labb9
{
    class NamnAdress
    {
        public string FörNamn = "";
        public string EfterNamn = "";
        public string gatuadres = "";

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            // Lagra uppgifter i ett objekt
            List<NamnAdress> list = new List<NamnAdress>();

            // Upprepa tills användaren skriver tomt
            while (true)
            {
                 NamnAdress objekt = new NamnAdress();

                // Ange förnamn namn 
                Console.WriteLine("Ange ditt förnamn: ");
                objekt.FörNamn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.FörNamn == "")
                {
                    break;
                }
                 // Ange Efter namn 
                Console.WriteLine("Ange ditt efternamn: ");
                objekt.EfterNamn = Console.ReadLine();
                // Ange Adres
                Console.WriteLine("Ange ditt gatuadres: ");
                objekt.gatuadres = Console.ReadLine();

                list.Add(objekt);
            }
        }
    }
}