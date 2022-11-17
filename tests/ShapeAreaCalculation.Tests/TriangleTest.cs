using ShapeAreaCalculation.Entities;
using ShapeAreaCalculation.Exceptions;

namespace ShapeAreaCalculation.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Create_Triangle_ReturnTriangleObject()
        {
            var triangle = new Triangle(12,12,12);

            triangle.Should().NotBeNull();
        }

        [Fact]
        public void IsRight_Triangle_ReturnTrue()
        {
            var triangle = new Triangle(12, 13, 5);

            var result = triangle.IsRight();

            result.Should().BeTrue();   
        }
        [Fact]
        public void IsRight_TriangleReturnFalse()
        {
            var triangle = new Triangle(12, 12, 12);

            var result = triangle.IsRight();

            result.Should().BeFalse();
        }
        [Fact]
        public void GetArea_Triangle_ReturnArea()
        {
            var triangle = new Triangle(12, 13, 5);

            var result = triangle.GetArea();

            result.Should().Be(30);
        }

        [Fact]
        public void Validate_Triangle_ThrowException()
        {
            var triangle = new Triangle(0, 13, 5);

            triangle.Invoking(t=>t.Validate()).Should().Throw<TriangleInvalidSideException>();
        }


    }
}
