namespace Assignment2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            string userInput;
            do
            {
                double num1;
                double num2;

                do
                {
                    Console.WriteLine("This program calculates the area of a square, a circle, and a rectangle. Please select a shape.");
                    Console.WriteLine("Enter S for square.");
                    Console.WriteLine("Enter C for circle.");
                    Console.WriteLine("Enter R for rectangle.");
                    Console.WriteLine("Enter X to exit the program.");

                    userInput = Console.ReadLine();
                } while (userInput == "");

                switch (userInput)
                {
                    case "S":
                    case "s":
                        num1 = GetNumberFromUser("length", "square");
                        Square square = new Square();
                        square.CalculateArea(num1);
                        break;
                    case "C":
                    case "c":
                        num1 = GetNumberFromUser("radius", "circle");
                        Circle circle = new Circle();
                        circle.CalculateArea(num1);
                        break;
                    case "R":
                    case "r":
                        num1 = GetNumberFromUser("base", "rectangle");
                        num2 = GetNumberFromUser("height", "rectangle");
                        Rectangle rectangle = new Rectangle();
                        rectangle.CalculateArea(num1, num2);
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.WriteLine("That was not one of the choices.");
                        break;
                }
            } while (userInput != "X" && userInput != "x");
        }

        static double GetNumberFromUser(string location, string shape)
        {
            string input;
            do
            {
                Console.WriteLine("Please enter the " + location + " of the " + shape);
                input = Console.ReadLine();
            } while (input == "");
            return Convert.ToDouble(input);
        }
    }

    public enum ColorValues
    {
        Red,
        Blue,
        Green
    }


    public abstract class Shape
    {
        public string ShapeID { get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValues Color { get; set; }

        public virtual void CalculateArea()
        {
            Console.WriteLine("This shape has an area.");
        }

    }

    public class Square : Shape 
    {
        public double LengthOfSide { get; set; }

        public void CalculateArea(double lengthOfSide)
        {
            Console.WriteLine("The area of a square is: " + Math.Pow(lengthOfSide,2));
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public void CalculateArea(double radius)
        {
            Console.WriteLine("The area of a circle is: " + Math.PI * Math.Pow(radius, 2));
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void CalculateArea(double width, double height)
        {
            Console.WriteLine("The area of a rectangle is: " + width * height);
        }

    }
}
