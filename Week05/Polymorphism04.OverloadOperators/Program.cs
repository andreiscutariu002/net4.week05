namespace Polymorphism04.OverloadOperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new Point(1, 2);

            var p2 = new Point(4, 5);

            var p3 = p1 + p2;
        }
    }
}
