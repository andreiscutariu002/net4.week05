namespace Polymorphism02
{
    using System;

    public class Rectangle : Figure
    {
        private readonly int lat;
        private readonly int lon;

        public Rectangle(int lat, int lon)
        {
            this.lat = lat;
            this.lon = lon;
        }

        public override double GetArea()
        {
            return this.lat * this.lon;
        }
    }
}