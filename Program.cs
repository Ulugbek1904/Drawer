using System;

namespace Drawer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWelcome to Drawer");

            bool continueDrawing = true;

            while (continueDrawing)
            {
                try
                {
                    Console.WriteLine("\n\nSelect wanted shape from menu:");
                    Console.WriteLine("1. Square".PadRight(30) + "4. Line");
                    Console.WriteLine("2. Triangle".PadRight(30) + "5. Rectangle");
                    Console.WriteLine("3. Circle".PadRight(30) + "6. Rhombus");
                    Console.WriteLine();

                    string userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out int input) || input < 1 || input > 6)
                    {
                        throw new Exception("Your input must be an integer in the range from 1 to 6.");
                    }

                    Console.WriteLine("What symbol do you want to draw? e.g *, ^");
                    string symbolInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(symbolInput) || symbolInput.Length != 1)
                    {
                        throw new Exception("Please enter a single character.");
                    }
                    char incomingChar = symbolInput[0];

                    switch (input)
                    {
                        case 1:
                            drawSquare(incomingChar);
                            break;
                        case 2:
                            drawTriangle(incomingChar);
                            break;
                        case 3:
                            drawCircle(incomingChar);
                            break;
                        case 4:
                            drawSLine(incomingChar);
                            break;
                        case 5:
                            drawRectangle(incomingChar);
                            break;
                        case 6:
                            drawPrhombus(incomingChar);
                            break;
                        default:
                            Console.WriteLine("Please enter a number in the range 1 to 6.");
                            break;
                    }

                    Console.WriteLine("Do you want to draw again? yes/no");
                    string yesno = Console.ReadLine().ToLower();
                    continueDrawing = yesno == "yes";
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter valid values.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static void drawSquare(char charac)
        {
            try
            {
                Console.Write("Enter side length: ");
                int side = int.Parse(Console.ReadLine());
                for (int height = 0; height < side; height++)
                {
                    for (int width = 0; width < side; width++)
                    {
                        Console.Write(charac + "  ");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a numeric value.");
            }
        }

        public static void drawTriangle(char charac)
        {
            try
            {
                Console.Write("Enter height: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = num; i >= 1; i--)
                {
                    int count = 0;
                    for (int space = 1; space <= i; space++)
                    {
                        Console.Write(" ");
                        count++;
                    }

                    for (int j = 1; j <= num - count; j++)
                    {
                        Console.Write(charac);
                    }

                    for (int j1 = 0; j1 <= num - i; j1++)
                    {
                        Console.Write(charac);
                    }

                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a numeric value.");
            }
        }

        public static void drawRectangle(char charac)
        {
            try
            {
                Console.Write("Enter height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                int width = int.Parse(Console.ReadLine());

                for (int h = 0; h < height; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        Console.Write(charac + "  ");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numeric values.");
            }
        }

        public static void drawCircle(char charac)
        {
            Console.WriteLine("Circle drawing is not implemented yet.");
        }

        public static void drawPrhombus(char charac)
        {
            try
            {
                Console.Write("Enter half height: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = num; i >= 1; i--)
                {
                    int count = 0;
                    for (int space = 1; space < i; space++)
                    {
                        Console.Write(" ");
                        count++;
                    }
                    for (int j = 1; j <= num - count; j++)
                    {
                        Console.Write($"{charac} ");
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i <= num; i++)
                {
                    int count = 0;
                    for (int space = 1; space < i; space++)
                    {
                        Console.Write(" ");
                        count++;
                    }
                    for (int j = num - count; j >= 1; j--)
                    {
                        Console.Write($"{charac} ");
                    }

                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a numeric value.");
            }
        }

        public static void drawSLine(char charac)
        {
            try
            {
                Console.Write("Enter length: ");
                int length = int.Parse(Console.ReadLine());

                for (int i = 0; i < length; i++)
                {
                    Console.Write(charac);
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a numeric value.");
            }
        }
    }
}
