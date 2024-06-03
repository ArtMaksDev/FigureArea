namespace Figures.Helpers;

public static class TriangleHelper
{
    public static double GetPerimeter(in double sideA, in double sideB, in double sideC)
    {
        return sideA + sideB + sideC;
    }

    public static double GetSquare(in double sideA, in double sideB, in double sideC)
    {
        var halfPerimeter = GetPerimeter(sideA, sideB, sideC) / 2;

        return Math.Sqrt(
            halfPerimeter
            * (halfPerimeter - sideA)
            * (halfPerimeter - sideB)
            * (halfPerimeter - sideC));
    }
    public static bool GetIsRectangular(in double sideA, in double sideB, in double sideC)
    {
        return sideA == sideB || sideA == sideC || sideB == sideC;
    }
}