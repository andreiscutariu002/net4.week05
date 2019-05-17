namespace Polymorphism03.Overload
{
    using System;
    using System.Data;

    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int i, int i1, int i2, int i3)
        {
            return i + i1 + i2 + i3;
        }
    }

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
