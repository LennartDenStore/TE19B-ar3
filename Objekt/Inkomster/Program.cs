using System;

namespace Inkomster
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            // Lagra uppgifter i ett objekt
            PersonInkomst objekt = new PersonInkomst();
            List<PersonInkomst> list = new List<PersonInkomst>();

            // Upprepa tills användaren skriver tomt
            while (true)
            {
                // Ange namn och lön
                Console.WriteLine("Ange ditt namn: ");
                objekt.namn = Console.ReadLine("");

                // Avbryt om namn är tomt
                if (objekt.Namn == "")
                {
                    break;
                }
                Console.WriteLine("Ange din månadslön");
                objekt.Lön = readInt();

                // Läg in listan
                lista.Add(objekt);

                // Avbryt om lön är tomt
                if (objekt.Lön == "")
                {
                    break;
                }
            }
        }
        static int readInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen");
            }
            return heltal;
        }
    }
}
