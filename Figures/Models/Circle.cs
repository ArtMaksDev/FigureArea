using Figures.Helpers;
using Figures.Interfaces;

namespace Figures.Models
{
    public class Circle : ICircle
    {
        public double Radius { get; }
        public double Square { get; }

        public Circle(double radius)
        {
            CircleHelper.Validate(radius);

            Radius = radius;
            Square = CircleHelper.GetSquare(radius);
        }
    }
}
