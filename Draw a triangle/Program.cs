using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {   
            int limit = 5;        
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the square top-left");
                Console.WriteLine("3. Draw the square top-right");
                Console.WriteLine("4. Draw the square botton-left");
                Console.WriteLine("5. Draw the square botton-right");
                Console.WriteLine("6. Draw isosceles triangle");
                Console.WriteLine("7. Draw inverted isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (int i = 1; i <= 3; i++)
                        {
                            for (int j = 1; j <= 6; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;
                    case 2:
                        for (int i = limit; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;
                    case 3:
                        for (int i = limit; i >= 1; i--)
                        {
                            for (int j = 1; j <= limit - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;
                    case 4:
                        for (int i = 1; i <= limit; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;
                    case 5:
                        for (int i = 1; i <= limit; i++)
                        {
                            for (int j = 1; j <= limit - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;
                    case 6:
                        for (int i = 1; i <= limit; i++)
                        {
                            for (int j = 1; j <= limit - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 1; j <= 2 * i - 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        for (int i = limit; i >= 1; i--)
                        {
                            for (int j = 1; j <= limit - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 1; j <= 2 * i - 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(); 
                        }
                        break;     
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}