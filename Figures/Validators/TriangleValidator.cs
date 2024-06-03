#region usings

using Figures.Exceptions;
using Figures.Models;

#endregion

namespace Figures.Validators;

public class TriangleValidator : FigureSideValidator
{
    public void Validate(Side sideA, Side sideB, Side sideC)
    {
        CheckSides(sideA, sideB, sideC);

        Side largestSide;
        Side smallerSide1;
        Side smallerSide2;

        if (sideA.Value >= sideB.Value)
        {
            largestSide = sideA;
            smallerSide1 = sideB;
        }
        else
        {
            largestSide = sideB;
            smallerSide1 = sideA;
        }

        if (largestSide.Value < sideC.Value)
        {
            smallerSide2 = largestSide;
            largestSide = sideC;
        }
        else
        {
            smallerSide2 = sideC;
        }

        if (smallerSide1.Value + smallerSide2.Value <= largestSide.Value)
        {
            throw new TriangleSidesIsNotValidException(sideA, sideB, sideC);
        }
    }
}