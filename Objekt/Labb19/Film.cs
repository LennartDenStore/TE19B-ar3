using System;

namespace Labb19
{
    public class Film : Media
    {
        public string Direktor { get; set; }
        public int Length { get; set; }

        public Film(string title, string regissör, string längd)
        {

        }
        public override string TillText()
        {
           return null;
        }
    }
}