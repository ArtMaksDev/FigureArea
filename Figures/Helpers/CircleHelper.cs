#region usings

using Figures.Exceptions;

#endregion

namespace Figures.Helpers;

public class CircleHelper
{
    public static void Validate(in double radius)
    {
        if (radius <= 0)
        {
            throw new CircleRadiusIsNotPositiveException(radius);
        }
    }

    public static double GetSquare(in double radius)
    {
        return Math.PI * Math.Pow(radius, 2d);
    }
}