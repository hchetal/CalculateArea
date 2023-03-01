using System;

namespace CalculateArea
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Rectangle(double length, double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }

        public void CalculateArea()
        {
            var calculatedArea = this.Length * this.Breadth;
            Console.WriteLine($"Area of a Rectange is {calculatedArea}");
            Console.Read();
        }
    }
}
