﻿using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KlassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut lönekostnad");

            // Loopa ett antal gånger 
            IList<personinkomst> listaPerson = new List<personinkomst>();


            while (true)
            {
                // Skapa objektet person från klassen personinkomsr
                personinkomst person = new personinkomst();

                // Ange namn 
                Console.Write("vad heter den anställde?  ");
                person.namn = Console.ReadLine();

                // Avslutar om namn är tomt
                if (person.namn == "")
                {
                    break;
                }

                // ange timlön
                Console.Write("Den anställdes timlön  ");
                person.timlön = ReadInt();

                // Ange timmar
                Console.Write("Den anställdes arbetstid:  ");
                person.timmar = ReadInt();

                // Lagra i listan
                listaPerson.Add(person);
            }

            // Spara ned som jison
            string jsonText = JsonConvert.SerializeObject(listaPerson,Formatting.Indented);

            // Spara ned i JSON i textfil
            File.WriteAllText(@"personerinkomst.json", jsonText);

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
