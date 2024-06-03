#region usings

using Figures.Models;

#endregion

namespace Figures.Exceptions;

public class TriangleSidesIsNotValidException : Exception
{
    private readonly Side _sideA;
    private readonly Side _sideB;
    private readonly Side _sideC;

    public TriangleSidesIsNotValidException(Side sideA, Side sideB, Side sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public override string Message =>
        "Длина наибольшей стороны меньше суммы длин двух других сторон." +
        $"\nСторона {_sideA.Name}:{_sideA.Value}" +
        $"\nСторона {_sideB.Name}:{_sideB.Value}" +
        $"\nСторона {_sideC.Name}:{_sideC.Value}";
}