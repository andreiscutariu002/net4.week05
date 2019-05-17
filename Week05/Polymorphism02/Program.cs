using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism02
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<IFigure>();

            figures.Add(new Circle(20));

            figures.Add(new SuperCircle(10));

            figures.Add(new SuperSuperCircle(20));

            figures.Add(new Rectangle(5, 4));

            foreach (var figure in figures)
            {
                figure.PrintArea();
            }
        }
    }
}
