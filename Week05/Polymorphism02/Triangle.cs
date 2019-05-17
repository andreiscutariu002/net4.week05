namespace Polymorphism02
{
    using System;

    public class Triangle : Figure
    {
        private readonly int l1;
        private readonly int l2;
        private readonly int l3;

        public Triangle(int l1, int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public override double GetArea()
        {
            return (this.l1 + this.l2 + this.l3);
        }
    }
}