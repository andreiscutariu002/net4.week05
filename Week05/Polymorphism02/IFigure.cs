namespace Polymorphism02
{
    using System;

    public interface IFigure
    {
        double GetArea();

        void PrintArea();
    }

    public abstract class Figure : IFigure
    {
        public abstract double GetArea();

        public virtual void PrintArea()
        {
            Console.WriteLine("My area: " + this.GetArea());
        }
    }
}