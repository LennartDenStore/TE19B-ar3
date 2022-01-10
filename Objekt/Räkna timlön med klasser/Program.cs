using System;

namespace Räkna_timlön_med_klasser
{
    public class PersonInkomst
    {
        public string namn;
        public int inkomst;
        public int timmar;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar objektet person1 från klassen PersonInkomst
            PersonInkomst person1 = new PersonInkomst();
            
             Console.Write("Ange ditt namn: ");
            string namn1 = Console.ReadLine();
            System.Console.Write("Ange din inkomst: ");
            int inkomst1 = int.Parse(Console.ReadLine());
            Console.Write("Ange antal timmar: ");
            int timmar1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Din timlön blev {inkomst1 / timmar1} kr/h");

            // Skapa ett till objekt person2
            PersonInkomst person2 = new PersonInkomst();
            Console.Write("Ange ditt namn: ");
            string namn2 = Console.ReadLine();
            System.Console.Write("Ange din inkomst: ");
            int inkomst2 = int.Parse(Console.ReadLine());
            Console.Write("Ange antal timmar: ");
            int timmar2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Din timlön blev {inkomst2 / timmar2} kr/h");

            // Skapa ett till objekt person2
            PersonInkomst person3 = new PersonInkomst();
            Console.Write("Ange ditt namn: ");
            string namn3 = Console.ReadLine();
            System.Console.Write("Ange din inkomst: ");
            int inkomst3 = int.Parse(Console.ReadLine());
            Console.Write("Ange antal timmar: ");
            int timmar3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Din timlön blev {inkomst3 / timmar3} kr/h");
        }
    }
}
