using System;
using System.Collections;
using System.Diagnostics;

namespace Drawer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("\t\t\t Welcome to Drawer");

            bool continueDrawing = true;

            // while orqali biz dasturni qachin tugashini optional qila olamiz

            while(continueDrawing)
            {
                System.Console.WriteLine("\n\n");
                System.Console.WriteLine("Select wanted shape from menu :");

                System.Console.WriteLine("1. Square ".PadRight(30) + "4. Line");
                System.Console.WriteLine("2. Triangle".PadRight(30) + "5. rectangle");
                System.Console.WriteLine("3. Circle".PadRight(30) + "6. rhombus");

                string Userinput = Console.ReadLine();
                int input = int.Parse(Userinput);

                // shakllarni user istagan belgi orqali chiza oladi
                System.Console.WriteLine("What symbol do you want to draw ? e.g *, ^");
                string userInput = Console.ReadLine();
                char incomingChar = char.Parse(userInput);

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
                    default :
                        Console.WriteLine("Please enter a number range 1 to 6");
                        break;
                }
                
                Thread.Sleep(1000);

                System.Console.WriteLine("Do you want to do again? yes/no");
                string yesno = Console.ReadLine();
                continueDrawing = yesno.ToLower() == "yes" ;

            }

        }

        // draw methodlarini alohida qilib olish dasturni ishlashini yaxshilaydi.
        public static void drawSquare(char charac)
        {
            System.Console.Write("enter side :");
            int inp = int.Parse(Console.ReadLine());
            for (int heigth = 0; heigth < inp; heigth++)
            {
                for (int width =0; width < inp; width++)
                {
                    System.Console.Write(charac + "  ");
                }
                System.Console.WriteLine();
            }
        }
        public static void drawTriangle(char charac)
        {
            Console.Write("Enter height : ");
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
                    Console.Write("*");
                }

                for (int j1 = 0; j1 <= num - i; j1++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public static void drawRectangle(char charac)
        {
            System.Console.Write("enter Heigth :");
            int inp = int.Parse(Console.ReadLine());
            System.Console.Write("enter width :");
            int inp2 = int.Parse(Console.ReadLine());

            for (int heigth = 0; heigth < inp; heigth++)
            {
                for (int width =0; width < inp2; width++)
                {
                    System.Console.Write(charac + "  ");
                }
                System.Console.WriteLine();
            }
            
        }
        public static void drawCircle(char charac)
        {
            System.Console.WriteLine("circle");
            
        }
        public static void drawPrhombus(char charac)
        {
            Console.Write("enter halfHeigth : ");
            int num = int.Parse(Console.ReadLine());

            for (int i =num; i >= 1; i--)
            {
                int count = 0;
                for (int space = 1; space < i; space++)
                {
                    Console.Write(" ");
                    count++;
                }
                for (int j =1; j <= num - count; j++)
                {
                    Console.Write("* ");
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
                for(int j = num - count; j >= 1; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            
        }
        public static void drawSLine(char charac)
        {
            Console.Write("Enter Lentgh : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                System.Console.Write(charac);
            }
            System.Console.WriteLine(Environment.NewLine);
        }
    }
}