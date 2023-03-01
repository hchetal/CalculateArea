using System;

namespace CalculateArea
{
    public class Square : IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            this.Side = side;
        }

        public void CalculateArea()
        {
            var calculatedArea = this.Side * this.Side;
            Console.WriteLine($"Area of a square is {calculatedArea}");
            Console.Read();
        }

    }
}
