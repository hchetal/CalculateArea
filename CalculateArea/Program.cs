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
                double radius = double.Parse(Console.ReadLine());

                shape = creator.CreateShape("c", radius);
                shape.CalculateArea();

            }
            else if (optionChosen == "s" || optionChosen == "3")
            {
                Console.WriteLine("Enter the side");
                double side = double.Parse(Console.ReadLine());

                shape = creator.CreateShape("s", side);
                shape.CalculateArea();
            }
            else if (optionChosen == "r" || optionChosen == "1")
            {
                Console.WriteLine("Enter the length");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the breadth");
                double breadth = double.Parse(Console.ReadLine());

                shape = creator.CreateShape("r", length,breadth);
                shape.CalculateArea();
            }
            else
                Console.WriteLine("Invalid Option");

            Console.Read();
        }
    }

    
}
