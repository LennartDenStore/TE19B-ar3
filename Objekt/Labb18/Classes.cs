using System;

namespace Labb18
{
    public class Classes
    {
        public class Creature
        {
            public int Health { get; set; }
            public int Sheald { get; set; }
            protected string Name { get; set; }

            public Creature(string name)
            {
                Name = name;
            }
            public string GetInfo()
            {
                return null;
            }
        }
        public class Knight : Creature
        {
            protected string Weapon { get; set; }
            public Knight(string name, string weapon) : base(name)
            {
                
                Weapon = weapon;
            }
            public void Attack()
            {

            }
        }

        public class Dragon : Creature
        {
            protected string Color { get; set; }

            public Dragon(string name, string color) : base(name)
            {
            
                Color = color;

            }
            public void Attack()
            {

            }

        }



    }
}