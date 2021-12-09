using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

namespace Labb13
{
    class Namn
    {
        public string FörNamn {get; set;}
        public string EfterNamn {get; set;}
        public DateTime Födelsedag {get; set;}


        public void VisaHellaNamnet()
        {
            Console.WriteLine($"{FörNamn}{EfterNamn}");
        }
        public void VisaÅlder()
        {
            int ålder = DateTime.Now.Year - Födelsedag.Year;
            Console.WriteLine("{ålder}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Now;
            Console.WriteLine($"Dagens datum är {datum}");
            Console.WriteLine($"Dagens månad är {datum.Month}");
            Console.WriteLine($"Dagens dag är {datum.Day}");
            Console.WriteLine($"Vi ar datum {datum.Hour}:{datum.Minute}");

            // Formatera datum
            Console.WriteLine($"Dagens dag är {datum.ToString("dddd")}");
            Console.WriteLine($"Dagens dag är {datum.ToString("1010")}");

            // om 40 dagar skall arbetet vara klart, vilken dag ska det vara klart
            DateTime deadline = datum.AddDays(40);
            Console.WriteLine($"Dagens dag är {deadline.ToString("dddd dd/MM-yy")}");

            // Be om födelsedatum
            Console.WriteLine("När är du för? (dd-mm-yyyy) ");
            DateTime födelsedatum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(födelsedatum);

            // Berätta hur gammal användaren är?
            Console.WriteLine($"Din ålder är{datum.Year - födelsedatum.Year}");
            Console.WriteLine($"Din ålder är{GetAge(födelsedatum)}");

            
         List<Namn> lista = new List<Namn>();
         while (true)
            {
                Namn objekt = new Namn();
                Console.Write("Ange ditt namn: ");
                objekt.FörNamn = Console.ReadLine();
                // Avbryt om namn är tomt
                if (objekt.FörNamn == "")
                {
                    break;
                }
                Console.Write("Ange ditt efter namn: ");
                objekt.EfterNamn = Console.ReadLine();
                Console.Write("Ange ditt födelse datum: ");
                objekt.Födelsedag = DateTime.Parse(Console.ReadLine());
                lista.Add(objekt);

            }
            
         }
         static public int GetAge(DateTime datum)
        {
            double age = 0;
            age = DateTime.Now.Subtract(datum).Days;
            age = age / 365.25;
            return (int)Math.Floor(age);    
        }

    }         

}
