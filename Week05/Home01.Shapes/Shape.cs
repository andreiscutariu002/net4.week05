namespace Home01.Shapes
{
    public abstract class Shape
    {
        protected readonly int W;

        protected readonly int H;

        protected Shape(int w, int h)
        {
            this.W = w;
            this.H = h;
        }

        public abstract double CalculateSurface();
    }
}