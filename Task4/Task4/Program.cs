// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the first integer :");
int firstInt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second integer :");
int secondInt = Convert.ToInt32(Console.ReadLine());


int a = firstInt, b = secondInt;

Console.WriteLine($"Before swap: a = {a}, b = {b}");

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"After swap: a = {a}, b = {b}");