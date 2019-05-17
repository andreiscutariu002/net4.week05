namespace Home01.Shapes
{
    public class Square : Shape
    {
        public Square(int l) : base(l, l)
        {
        }

        public override double CalculateSurface()
        {
            return this.W * this.H;
        }
    }
}