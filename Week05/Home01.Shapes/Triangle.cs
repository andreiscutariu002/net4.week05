namespace Home01.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int w, int h) : base(w, h)
        {
        }

        public override double CalculateSurface()
        {
            return this.W * this.H;
        }
    }
}