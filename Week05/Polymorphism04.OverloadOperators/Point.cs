namespace Polymorphism04.OverloadOperators
{
    public class Point
    {
        private readonly int x;
        private readonly int y;

        public Point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator + (Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator ++(Point p1)
        {
            return new Point(p1.x + 1, p1.y + 1);
        }
    }
}