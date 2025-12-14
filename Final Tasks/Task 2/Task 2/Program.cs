using System;

abstract class Payment
{
    private string accountNumber;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public abstract void ProcessPayment(double amount);
}

class BkashPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing Bkash payment: " + amount);
    }
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing Credit Card payment: " + amount);
    }
}

class Program
{
    static void Main()
    {
        Payment p1 = new BkashPayment();
        p1.AccountNumber = "BK12345";

        Payment p2 = new CreditCardPayment();
        p2.AccountNumber = "CC98765";

        p1.ProcessPayment(500);
        p2.ProcessPayment(1200);
    }
}