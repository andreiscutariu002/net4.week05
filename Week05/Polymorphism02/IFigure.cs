namespace Polymorphism02
{
    using System;

    public interface IFigure
    {
        double GetArea();

        void PrintArea();

        string MyType();
    }

    public abstract class Figure : IFigure
    {
        public abstract double GetArea(); // mandatory to implement in derived types

        public virtual void PrintArea() // can be overriden in derived types
        {
            Console.WriteLine("My area: " + this.GetArea());
        }

        public string MyType() // cannot be overriden in derived types
        {
            return this.GetType().ToString();
        }
    }
}