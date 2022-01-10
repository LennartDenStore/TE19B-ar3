using System.ComponentModel;
using System;

namespace KlasserOchObjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 0;

            // Create objekt of class type Box
            Box box1 = new Box();
            Box box2 = new Box();

            Console.WriteLine("<skriv en längd för box 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("<skriv ett djup för box 1: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("<skriv en höjd för box 1: ");
            double n3 = double.Parse(Console.ReadLine());

            box1.Length = n1;
            box1.Breadth = n2;
            box1.Hight = n3;
            double Volume = box1.getVolume();
            double Area = box1.getArea();

            Console.WriteLine("<skriv en längd för box 2: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("<skriv ett Djup för box 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("<skriv en höjd för box 2: ");
            n3 = double.Parse(Console.ReadLine());

            box2.Length = n1;
            box2.Breadth = n2;
            box2.Hight = n3;

            Console.WriteLine($"Box 1 Dimensions Are: {box1.Length},{box1.Breadth},{box1.Hight}");
            Console.WriteLine($"Box 1 volume is: {Volume}");
            Console.WriteLine($"Box 1 area is: {Area}");

            Console.WriteLine($"Box 2 Dimensions Are: {box2.Length},{box2.Breadth},{box2.Hight}");
            Console.WriteLine($"Box 2 volume is: {box2.getVolume()}");
            Console.WriteLine($"Box 2 area is: {box2.getArea()}");
        }
    }
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Hight { get; set; }
        public double getVolume()
        {
            return Length * Breadth * Hight;
        }
        public double getArea()
        {
            return Length * Breadth;
        }
    }
}
