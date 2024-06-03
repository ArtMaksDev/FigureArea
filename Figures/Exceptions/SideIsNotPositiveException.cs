#region usings

using Figures.Models;

#endregion

namespace Figures.Exceptions;

public class SideIsNotPositiveException : Exception
{
    private readonly Side _side;

    public SideIsNotPositiveException(Side side)
    {
        _side = side;
    }

    public override string Message =>
        $"Cторона {_side.Name} должна быть больше 0. Текущее значение: {_side.Value}";
}