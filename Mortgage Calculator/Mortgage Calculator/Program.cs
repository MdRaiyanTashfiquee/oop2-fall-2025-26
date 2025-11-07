// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mortgage Calculator ");

        Console.Write("Enter loan amount: ");
        double P = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int t = Convert.ToInt32(Console.ReadLine());

        double monthlyInterestRate = (r / 100) / 12;
        int n = t * 12;

        double m =
            (P * r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);

        double totalPaid = m * n;
        double totalInterest = totalPaid - P;
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine($"Monthly Payment: {m.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid:0,0.00}৳");
        Console.WriteLine($"Total Interest: {totalInterest:0,0.00}৳");
    }
}




