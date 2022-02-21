using System;

namespace Labb19
{
    public class Bok : Media
    {
        public string Author { get; set; }
        public int NrOfPage { get; set; }

        public  Bok (string title, string författare, string antalSidor)
        {
            
        }
        public override string TillText()
        {
           return null;
        }
    }
}