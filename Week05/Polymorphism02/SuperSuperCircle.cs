namespace Polymorphism02
{
    using System;

    public class SuperSuperCircle : SuperCircle
    {
        public SuperSuperCircle(int r) : base(r)
        {
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R * 3;
        }

        public override void PrintArea()
        {
            Console.WriteLine("My super area: " + this.GetArea());
        }
    }
}