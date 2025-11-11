using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mortgage Calculator (Bangladesh)");

        CultureInfo bdCulture = new CultureInfo("bn-BD");

        double salary = 0;
        double creditscore = 0;
        bool criminalrecord = false;

        while (true)
        {
            Console.Write("Enter your monthly salary: ");
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out salary) && salary > 0)
                break;
            Console.WriteLine("Invalid input: please enter a positive number.");
        }

        while (true)
        {
            Console.Write("Enter your Credit Score (0-500): ");
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out creditscore) && creditscore >= 0 && creditscore <= 500)
                break;
            Console.WriteLine("Invalid input: please enter a number between 0 and 500.");
        }

        while (true)
        {
            Console.Write("Do you have any Criminal Record? (True/False): ");
            string input = Console.ReadLine() ?? string.Empty;
            if (bool.TryParse(input, out criminalrecord))
                break;
            Console.WriteLine("Invalid input: please enter True or False.");
        }

        double eligibleLoanAmount = 2 * salary;
        bool isEligible = creditscore > 299 && creditscore < 501 && !criminalrecord;

        if (!isEligible)
        {
            Console.WriteLine("You're not eligible to get a loan.");
            return;
        }

        Console.Write("Enter desired loan amount: ");
        double P = Convert.ToDouble(Console.ReadLine());

        if (P > eligibleLoanAmount)
        {
            Console.WriteLine("You cannot take this much loan amount.");
            return;
        }

        Console.Write("Enter annual interest rate (in %): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int t = Convert.ToInt32(Console.ReadLine());

        double monthlyInterestRate = (r / 100) / 12;
        int n = t * 12;

        double m = (P * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, n)) /
                   (Math.Pow(1 + monthlyInterestRate, n) - 1);

        double totalPaid = m * n;
        double totalInterest = totalPaid - P;

        Console.WriteLine("Your loan is approved!");
        Console.WriteLine($"Desired Loan Amount: {P.ToString("C", bdCulture)}");
        Console.WriteLine($"Monthly Payment: {m.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Loan Amount: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");

        Console.WriteLine("   Mortgage Summary  ");
        Console.WriteLine($"Monthly Salary: {salary.ToString("C", bdCulture)}");
        Console.WriteLine($"Credit Score: {creditscore}");
        Console.WriteLine($"Criminal Record: {criminalrecord}");
    }
}