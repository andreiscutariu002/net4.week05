namespace Polymorphism03.Overload
{
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
}