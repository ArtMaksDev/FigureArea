#region usings

using Figures.Exceptions;
using Figures.Models;
using NUnit.Framework;

#endregion

namespace Figures.Tests;

public class TriangleTests
{
    [Test]
    [TestCase(1, 1, 2)]
    [TestCase(1, 1, 3)]
    public void InitTriangle_InvalidSides_ThrowException(double sideA, double sideB, double sideC)
    {
        Assert.Catch<TriangleSidesIsNotValidException>(() =>
            _ = new Triangle(
                new Side("A", sideA),
                new Side("B", sideB),
                new Side("C", sideC)
            )
        );
    }

    [Test]
    [TestCase(-1, 1, -1)]
    public void InitTriangle_NotPositiveSides_ThrowException(double sideA, double sideB, double sideC)
    {
        Assert.Catch<SideIsNotPositiveException>(() =>
           _ = new Triangle(
                new Side("A", sideA),
                new Side("B", sideB),
                new Side("C", sideC)
            )
        );
    }

    [Test]
    [TestCase(3, 4, 5, 6)]
    public void GetSquare_ValidSide_ReturnCorrectValue(double sideA, double sideB, double sideC, double expectedResult)
    {
        Assert.That(
            new Triangle(
                new Side("A", sideA),
                new Side("B", sideB),
                new Side("C", sideC)
            ).Square,
            Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(2, 3, 4, 9)]
    public void GetPerimeter_ValidSide_ReturnCorrectValue(double sideA, double sideB, double sideC, double expectedResult)
    {
        Assert.That(
            new Triangle(
                    new Side("A", sideA),
                    new Side("B", sideB),
                    new Side("C", sideC)
            ).Perimeter,
            Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(5, 5, 8)]
    [TestCase(7, 8, 8)]
    [TestCase(10, 5, 10)]
    public void IsRectangular(double sideA, double sideB, double sideC)
    {
        Assert.That(
            new Triangle(
                new Side("A", sideA),
                new Side("B", sideB),
                new Side("C", sideC)
            ).IsRectangular,
            Is.True
        );
    }
}