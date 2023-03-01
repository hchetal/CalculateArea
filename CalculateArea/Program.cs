using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Console.WriteLine("Program for calculation of the area for the shapes");
            Console.WriteLine("Chose an option to select the shape");
            Console.WriteLine("1: Rectangle(r)");
            Console.WriteLine("2: Circle(c)");
            Console.WriteLine("3: Square(s)");

            Console.WriteLine("Enter the option");
            string optionChosen = Console.ReadLine();

            ShapeCreatorFactory creator = new ShapeCreatorFactory();
            IShape shape;
            

            if (optionChosen == "c" || optionChosen == "2")
            {
                Console.WriteLine("Enter the radius");
                double.TryParse(Console.ReadLine(), out double radius);

                shape = creator.CreateShape(Shape.Circle, radius);
                shape.CalculateArea();

            }
            else if (optionChosen == "s" || optionChosen == "3")
            {
                Console.WriteLine("Enter the side");
                double.TryParse(Console.ReadLine(), out double side);

                shape = creator.CreateShape(Shape.Square, side);
                shape.CalculateArea();
            }
            else if (optionChosen == "r" || optionChosen == "1")
            {
                Console.WriteLine("Enter the length");
                double.TryParse(Console.ReadLine(), out double length);

                Console.WriteLine("Enter the breadth");
                double.TryParse(Console.ReadLine(), out double breadth);

                shape = creator.CreateShape(Shape.Rectangle, length,breadth);
                shape.CalculateArea();
            }
            else
                Console.WriteLine("Invalid Option");

            Console.Read();
        }
    }

    public enum Shape
    {
        Circle,
        Rectangle,
        Square
    }

    
}
