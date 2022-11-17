using ShapeAreaCalculation.Exceptions;

namespace ShapeAreaCalculation.Entities
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double GetArea()
        {
            Validate();
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p*(p-SideA) * (p - SideB) * (p - SideC));
        }

        public override void Validate()
        {
            if (SideA == 0 || SideB == 0 || SideC == 0)
            {
                throw new TriangleInvalidSideException();
            }
        }


        public bool IsRight()
        {
            if ((SideA * SideA + SideB * SideB == SideC * SideC) || 
                (SideA * SideA + SideC * SideC == SideB * SideB) || 
                (SideC * SideC + SideB * SideB == SideA * SideA))
            {
                return true;
            }
            return false;
        }
    }
}
