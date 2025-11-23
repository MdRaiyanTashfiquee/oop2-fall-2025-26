using System;

public class House
{

    public int YearBuilt { get; private set; }
    public double Size { get; private set; }
    public House(int yearBuilt, double size)
    {
        YearBuilt = yearBuilt;
        Size = size;
    }
    private int HowOld()
    {
        return DateTime.Now.Year - YearBuilt;
    }
    public bool CanBeSold()
    {
        return HowOld() > 15;
    }
}
class Program
{
    static void Main()
    {
        House myHouse = new House(2005, 120.5);
        Console.WriteLine("Year Built: " + myHouse.YearBuilt);
        Console.WriteLine("Size: " + myHouse.Size + " sq units");
        Console.WriteLine("Can the house be sold? " + (myHouse.CanBeSold() ? "Yes" : "No"));
    }
}