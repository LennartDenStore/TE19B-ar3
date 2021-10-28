using System;
using System.Collections.Generic;

namespace Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en array
            string[] städer = {"Berlin", "Paris", "London"};

            // Ett annat att skapa en array
            string[] frukter = new string[3];
            frukter[1] = "Äpple";
            frukter[2] = "Appelsin";
            frukter[3] = "Banaan";

            // Skapa en liista av namn
            List<string> namnaen = new List<string>() { "Miriam", "Teo", "Axel"};

            // Skapa en annan lista 
            List<string> bären = new List<string>();
            bären.Add("Blåbär");
            bären.Add("Lingon");
            bären.Add("Halon");
            bären.Add("Björnabär");
            bären.Add("Kråkbär");

            // Skriv ut alla frukter
            for (int i = 0; i < frukter.Length; i++)
            {
                Console.WriteLine(frukter[i]);
            }
            // En annan variant
            foreach (var frukt in frukter)
            {
                Console.WriteLine(frukt);
            }

            // Skriv ut aööa bären i listan
            for (int i = 0; i < bären.Count; i++)
            {
                Console.WriteLine(bären[i]);
            }

            // Om vi hitta en stad
            foreach (var stad in städer)
            {
                if (stad == "Paris")
                {
                    Console.WriteLine("Paris finns i  arrayen");
                }
            }

            // Om vi vill hitta ett bär (lista)
            if (bären.Contains("Blåbär"))
            {
                Console.WriteLine("Blåbär finns i listan");
            }

            // Tabort ett bär
            bären.Remove("Hallon");
            bären.RemoveAt(0);
            bären.Insert(1, "Aroniabär");

            foreach (var bär in bären)
            {
                Console.WriteLine(bär);
            }

        }
    }
}
