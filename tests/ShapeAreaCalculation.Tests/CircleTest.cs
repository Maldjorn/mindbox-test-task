
using ShapeAreaCalculation.Entities;
using ShapeAreaCalculation.Exceptions;

namespace ShapeAreaCalculation.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Create_Circle_ReturnsRectangle()
        {
            var rectangle = new Circle(14);

            rectangle.Should().NotBeNull();
        }


        [Fact]
        public void GetArea_Circle_ReturnsCorrectResult()
        {
            Circle circle = new Circle(10);

            var result = circle.GetArea();
            var expectedResult = 314.159265;
            result.Should().BeInRange(expectedResult, expectedResult + 1);
        }

        [Fact]
        public void GetArea_Circle_ThrowException()
        {
            Circle circle = new Circle(0);

            circle.Invoking(x=>x.GetArea()).Should().Throw<CircleInvalidRadiusException>();

        }

    }
}