namespace Polymorphism02
{
    using System;

    public class Circle : Figure
    {
        protected readonly int R;

        public Circle(int r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }
    }
}