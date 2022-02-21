using System;

namespace Labb15
{
    public class Tärning
    {
        private int Sidor {get; set;}

        public Tärning(int _sidor)
        {
            Sidor = _sidor;
        }
        public void SkrivUt()
        {
            Random generator = new Random();
            int slumptal = generator.Next (1,Sidor + 1);
            Console.WriteLine($"Du fick {slumptal} på D{Sidor} tärningen.");
        }
    }
}