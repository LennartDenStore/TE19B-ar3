using System;
using System.Collections.Generic;

namespace BilUthyrningen
{
    class Program
    {
        // Spara alla avtal
        static List<Avtal> ListaAvtal = new List<Avtal>();
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");
            string svar = "ja";
            while (svar == "ja")
            {
                // Skapa ett första avtal
                Avtal avtal = new Avtal();

                ListaAvtal.Add(avtal);

                Console.WriteLine("Anger kundens personnr: ");
                avtal.Personnr = Console.ReadLine();

                Console.WriteLine("Anger bilens regnr: ");
                avtal.RegNr = Console.ReadLine();
                while (!avtal.finnsRegnr())
                {
                    Console.Write("Ange bilens regnr: ");
                    avtal.RegNr = Console.ReadLine();
                }

                Console.WriteLine("Anger antal extra km: ");
                avtal.Km = int.Parse(Console.ReadLine());

                Console.WriteLine("Anger antal dygn: ");
                avtal.Tidsram = int.Parse(Console.ReadLine());
                avtal.Datum = DateTime.Today;

                // Räkna ut totala kostnaden

                Console.WriteLine($"Total hyra blir {avtal.RäknaKostnad()}Kr");
                Console.WriteLine($"Blir ska lämnas in {avtal.RäknaInlämningsdatum()}");
                Console.WriteLine("Vill du mata in ett till avtal? (ja/nej)");
                svar = Console.ReadLine().ToLower();
                //Console.WriteLine(avtal1.bilar["ABC123"]);
            }
        }
    }
    class Avtal
    {
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string Personnr { get; set; }

        private IDictionary<string, int> _bilar = new Dictionary<string, int>
        {
            {"ABC123", 500},
            {"DEF123", 400},
            {"GHI123", 199}
        };

        public bool finnsRegnr()
        {
            if (_bilar.ContainsKey(RegNr))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Räkna ut bilens dygnskostnad * antal dygn + frärdnings längd i km * 2
        /// </summary>
        /// <returns></returns>
        public float RäknaKostnad()
        {
            //Console.WriteLine(bilar["ABC123"]);

            Kostnad = _bilar[RegNr] * Tidsram + Km * 2;
            return Kostnad;

        }

        /// <summary>
        /// Räkna ut datum + tidsram
        /// </summary>
        /// <returns></returns>

        public string RäknaInlämningsdatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd/MMMM-yyyy");
        }
    }
    class kund
    {
        public string Personnr { get; set; }
        public string Fnamn { get; set; }
        public string Enamn { get; set; }
        public string Mobil { get; set; }
    }
}
