using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class ShapeCreatorFactory
    {
        public IShape CreateShape(Shape shape, double side1, double side2 = 0)
        {
            if (shape == Shape.Circle)
            {
                return new Circle(side1);
            }
            else if (shape == Shape.Square)
            {
                return new Square(side1);
            }
            else if (shape == Shape.Rectangle)
            {
                return new Rectangle(side1,side2);
            }
            return null;
        }
    }
}
