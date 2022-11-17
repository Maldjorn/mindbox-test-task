
namespace ShapeAreaCalculation.Entities
{
    public abstract class Shape
    {
        public string GetShapeName()
        {
            return this.GetType().Name;
        }

        public abstract double GetArea();
        public abstract void Validate();
    }
}