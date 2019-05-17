namespace Polymorphism02
{
    using System;

    public class SuperCircle : Circle
    {
        public SuperCircle(int r) : base(r)
        {
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R * 2;
        }

        //public override string MyType()
        //{
        //    return "Ceva";
        //}
    }
}