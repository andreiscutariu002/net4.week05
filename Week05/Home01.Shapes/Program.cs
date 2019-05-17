namespace Home01.Shapes
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<Shape>();

            list.Add(new Square(10));
            list.Add(new Rectangle(10, 20));
            list.Add(new Triangle(10, 2));

            foreach (var shape in list)
            {
                Console.WriteLine($"surface of {shape.GetType()} is {shape.CalculateSurface()}");
            }
        }
    }
}
