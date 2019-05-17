namespace Polymorphism03.Overload
{
    using System;
    using System.Data;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var calc = new Calculator();

            var r1 = calc.Add(1, 2);
            Console.WriteLine(r1);

            var r2 = calc.Add(1, 2, 3);
            Console.WriteLine(r2);

            var r3 = calc.Add(1, 2, 3, 4);
            Console.WriteLine(r3);

            var d1 = calc.Add(1.2d, 2.3d);
            Console.WriteLine(d1);
        }
    }
}
