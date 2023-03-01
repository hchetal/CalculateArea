using System;

namespace CalculateArea
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        const double Pie = 3.14;
        
        public Circle(double radius)
        {
            this.Radius = radius;            
        }

        public void CalculateArea()
        {
            var calculatedArea = Pie * this.Radius * this.Radius;
            Console.WriteLine($"Area of a Circle is {calculatedArea}");
            Console.Read();
        }
    }
}
