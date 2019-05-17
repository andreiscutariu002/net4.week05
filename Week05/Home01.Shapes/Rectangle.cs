namespace Home01.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int w, int h) : base(w, h)
        {
        }

        public override double CalculateSurface()
        {
            return (double) this.W * this.H / 2;
        }
    }
}