using System;

namespace Labb15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många sidor ska det vara på tärningen du vill kasta? ");
            int sidor = int.Parse(Console.ReadLine());

            Tärning tärning = new Tärning(sidor);
            tärning.SkrivUt();
        }
    }
}
