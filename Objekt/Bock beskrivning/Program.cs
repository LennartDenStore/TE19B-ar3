using System;

namespace Bock_beskrivning
{
    class Program
    {
        static List<Bock_beskrivning> ListaBock = new List<Bock_beskrivning>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! vill du skpa en bock med mig skriv ja!");
            string svar = "ja";
            while (svar == "ja")
            {
                // Ny bock 

                Console.WriteLine("Vad bock heter bocken du vil skapa?: ");
                bockInfo.Console.ReadLine();
            }
        }

    }
    class bockInfo
    {
        public string Titel {get; }
        public string Förfatare {get; }
        public string AntalSidor {get; }

        public string Titel()
        {
           Titel = "Hej världen";
           return Titel;
        }
    }
}
