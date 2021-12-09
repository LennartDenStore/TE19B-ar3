﻿using System;
using System.Collections.Generic;

namespace Inkomster
{
    class PersonInkomst
    {
        // Vareabler för att lagra data (Egenskaper)
        public string Namn {get; set;}     // Skyda variabeln från otilåten ändring
        public int Lön {get; set;}
        public int Timmar {get; set;}

        // Klassmetod
        public void VisaTimmLön()
        {
            Console.WriteLine($"Timlön för {Namn} är {Lön/Timmar}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            List<PersonInkomst> lista = new List<PersonInkomst>();

            // Upprepa tills användaren skriver tomt i namn
            while (true)
            {
                // Lagra uppgifter i ett objekt
                PersonInkomst objekt = new PersonInkomst();

                // Ange namn och lön
                Console.Write("Ange ditt namn (Enter avslutar): ");
                objekt.Namn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Namn == "")
                {
                    break;
                }

                Console.Write("Ange din månadslön: ");
                objekt.Lön = ReadInt();
                Console.Write("Ange antal timmar: ");
                objekt.Timmar = ReadInt();

                // Lägg in i listan
                lista.Add(objekt);
            }

            // Skriv ut lite statik: total lön, total timmar
            int totalLön = 0;
            int totalTimmar = 0;
            foreach (var anställd in lista)
            {
                totalLön += anställd.Lön;
                totalTimmar += anställd.Timmar;
                anställd.VisaTimmLön();
            }
            Console.WriteLine($"Den totala lönekostnaden är {totalLön}");
            Console.WriteLine($"Den totala inarbetade timmar är {totalTimmar}");
            

        }
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}