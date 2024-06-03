#region usings

using Figures.Exceptions;
using Figures.Models;
using NUnit.Framework;

#endregion

namespace Figures.Tests;

public class CircleTests
{
    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    public void InitCircle_InvalidRadius_ThrowException(double radius)
    {
        Assert.Catch<CircleRadiusIsNotPositiveException>(
            () => _ = new Circle(radius)
        );
    }

    [Test]
    [TestCase(10, 314)]
    public void GetSquare_ValidRadius_ReturnCorrectValue(double radius, double expectedResult)
    {

        Assert.That(
            Math.Round(
                new Circle(radius).Square
            ),
            Is.EqualTo(expectedResult)
        );
    }
}