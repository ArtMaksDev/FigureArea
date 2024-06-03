namespace Figures.Exceptions;

public class CircleRadiusIsNotPositiveException : Exception
{
    private readonly double _radius;

    public CircleRadiusIsNotPositiveException(double radius)
    {
        _radius = radius;
    }

    public override string Message =>
        $"Радиус круга должен быть больше 0. Текущее значение:{_radius}";
}