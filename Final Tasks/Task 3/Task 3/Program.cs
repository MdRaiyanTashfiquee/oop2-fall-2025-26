using System;

abstract class Employee
{
    private double basicSalary;

    public double BasicSalary
    {
        get { return basicSalary; }
        set { basicSalary = value; }
    }

    public abstract double GetTotalSalary();
}

class Manager : Employee
{
    public override double GetTotalSalary()
    {
        return BasicSalary + 2000;
    }
}

class Worker : Employee
{
    public override double GetTotalSalary()
    {
        return BasicSalary + 800;
    }
}

class Program
{
    static void Main()
    {
        Employee m = new Manager();
        m.BasicSalary = 10000;

        Employee w = new Worker();
        w.BasicSalary = 8000;

        Console.WriteLine("Manager Total Salary: " + m.GetTotalSalary());
        Console.WriteLine("Worker Total Salary: " + w.GetTotalSalary());
    }
}