// Write a program in C# to calculate area of triangle, square and rectangle.
// Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.
// 
// Area of Triange = base * height / 2
// Area of Square or Rectangle = length * width

namespace Assignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                string shape = "";
                double area = 0;
                bool validEntry = false;

                do
                {
                    double dimension1;
                    double dimension2;

                    Console.WriteLine("This program will calculate the area of a triangle, square, or rectangle.");
                    Console.WriteLine("Please select a shape:");
                    Console.WriteLine("1. Triangle");
                    Console.WriteLine("2. Square");
                    Console.WriteLine("3. Rectangle");
                    Console.WriteLine("4. Exit program");

                    Console.WriteLine();
                    string userInput = Console.ReadLine();
                    Console.WriteLine();

                    switch (userInput)
                    {
                        case "1":
                            shape = "triangle";
                            dimension1 = GetDimension(shape, "base");
                            dimension2 = GetDimension(shape, "height");
                            area = CalculateTriangleArea(dimension1, dimension2);
                            validEntry = true;
                            break;
                        case "2":
                            shape = "square";
                            dimension1 = GetDimension(shape, "side length");
                            area = CalculateRectangleArea(dimension1);
                            validEntry = true;
                            break;
                        case "3":
                            shape = "rectangle";
                            dimension1 = GetDimension(shape, "length");
                            dimension2 = GetDimension(shape, "width");
                            area = CalculateRectangleArea(dimension1, dimension2);
                            validEntry = true;
                            break;
                        case "4":
                            exit = true;
                            validEntry = true;
                            break;
                        default:
                            Console.WriteLine("Invalid entry. Please select a valid option.");
                            break;
                    }
                } while (!validEntry);

                if (exit)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                
                Console.WriteLine($"\nThe area of the {shape} is {area}.\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static double GetDimension(string shape, string dimension)
        {
            Console.Write($"Please input the value of the {shape}'s {dimension}: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double CalculateTriangleArea(double dimension1, double dimension2)
        {
            return dimension1 * dimension2 / 2;
        }

        static double CalculateRectangleArea(double dimension1, double dimension2)
        {
            return dimension1 * dimension2;
        }

        static double CalculateRectangleArea(double dimension1)
        {
            return dimension1 * dimension1;
        }
    }
}
