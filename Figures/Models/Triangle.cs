using Figures.Helpers;
using Figures.Interfaces;
using Figures.Validators;

namespace Figures.Models
{
    public class Triangle : ITriangle
    {
        public Side SideA { get; }
        public Side SideB { get; }
        public Side SideC { get; }
        public double Perimeter { get; }
        public double Square { get; }
        public bool IsRectangular { get; }

        public Triangle(Side sideA, Side sideB, Side sideC)
        {
            new TriangleValidator().Validate(sideA, sideB, sideC);

            Perimeter = TriangleHelper.GetPerimeter(sideA.Value, sideB.Value, sideC.Value);
            Square = TriangleHelper.GetSquare(sideA.Value, sideB.Value, sideC.Value);
            IsRectangular = TriangleHelper.GetIsRectangular(sideA.Value, sideB.Value, sideC.Value);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

    }
}
