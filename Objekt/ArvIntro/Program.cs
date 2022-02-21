using System.Reflection.Metadata.Ecma335;
using System;

namespace ArvIntro
{
    class Person
    {
        // prop
        public string Namn { get; set; }
        public string Mobil { get; set; }

        // func
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }
    }

    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");
        }
    }

    class Lärare : Person
    {
        public string AnstälningsÅr { get; set; }
        public string Ämne { get; set; }
        public void visaInfoLärare()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"AnstälningsÅr: {AnstälningsÅr}, Ämne: {Ämne}");
        }
        
    }
    // Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv - registrera personer på skolan");

           /*  while (true)
            {
                // Skapa en istans (objekte)
                Person person = new Person();
                
                Console.Write("Vad heter personen? ");
                person.Namn = Console.ReadLine();
                Console.Write("Vad personens mobilnumer? ");
                person.Mobil = Console.ReadLine();

                Console.WriteLine("Mata en till? (ja/nej)");
                if (Console.ReadLine() != "ja")
                    break;
            } */
            while (true)
            {
                // Skapa en istans (objekte)
                Student student = new Student();
                
                Console.Write("Vad heter Studenten? ");
                student.Namn = Console.ReadLine();
                Console.Write("Vad är studentens mobilnumer? ");
                student.Mobil = Console.ReadLine();
                Console.Write("Studentens årskurs? ");
                student.Mobil = Console.ReadLine();
                Console.Write("Ange program? ");
                student.Mobil = Console.ReadLine();

                student.VisaInfo();
                
                Console.WriteLine("Mata en till? (ja/nej)");
                if (Console.ReadLine() != "ja")
                    break;
            }
        }
    }
}
