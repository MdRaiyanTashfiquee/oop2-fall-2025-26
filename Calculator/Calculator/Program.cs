// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat;

            do
            {
                Console.WriteLine("=== Simple Calculator ===");
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("Your choice (1-4): ");
                string option = Console.ReadLine();

                Console.Write("Enter first number: ");
                double first = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double second = double.Parse(Console.ReadLine());

                double answer;

                switch (option)
                {
                    case "1":
                        answer = first + second;
                        Console.WriteLine($"Result = {answer}");
                        break;

                    case "2":
                        answer = first - second;
                        Console.WriteLine($"Result = {answer}");
                        break;

                    case "3":
                        answer = first * second;
                        Console.WriteLine($"Result = {answer}");
                        break;

                    case "4":
                        if (second == 0)
                            Console.WriteLine("Error: Division by zero!");
                        else
                            Console.WriteLine($"Result = {first / second}");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Try again!");
                        break;
                }

                Console.Write("\nDo you want another calculation? (yes/no): ");
                repeat = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

            } while (repeat == "yes");

            Console.WriteLine("Program ended. Goodbye!");
        }
    }
}