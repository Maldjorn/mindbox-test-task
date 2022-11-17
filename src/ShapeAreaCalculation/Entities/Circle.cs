using ShapeAreaCalculation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Entities
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            Validate();
            return Math.PI * Math.Pow(Radius,2);
        }

        public override void Validate()
        {
            if (Radius <= 0)
            {
                throw new CircleInvalidRadiusException();
            }
            
        }
    }
}
