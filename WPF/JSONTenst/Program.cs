using System;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace JSONTest
{
        // Mallen
    class Film{ 
        public string Titel;
        public string Årtal;
        public string Regissör;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skapa JSON-objekt");

                // Objektet Avatar
            Film avatar = new Film()
            {
                Titel = "Avatar",
                Årtal = "2009",
                Regissör = "James Cameron"
            };
            Film legend = new Film()
            {
                Titel = "Ia Am Legend",
                Årtal = "2008",
                Regissör = "Francis Lawrene"
            };
            Film interstellar = new Film()
            {
                Titel = "Interstellar",
                Årtal = "2014",
                Regissör = "Christopher Nolan"
            };

                // Skriv ut lite JISON
            string jsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            jsonText += ",\n" + JsonConvert.SerializeObject(legend, Formatting.Indented);
            jsonText += ",\n" + JsonConvert.SerializeObject(interstellar, Formatting.Indented);
            Console.WriteLine(jsonText);

                // Spara ned i json-fil
            File.WriteAllText("filmer.json", jsonText);

        }
    }
}
