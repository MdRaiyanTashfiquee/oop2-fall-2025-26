using System;

abstract class Member
{
    private string name;
    private int memberId;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int MemberId
    {
        get { return memberId; }
        set { memberId = value; }
    }

    public abstract int CalculateFee();
}

class StudentMember : Member
{
    public override int CalculateFee()
    {
        return 300;
    }
}

class RegularMember : Member
{
    public override int CalculateFee()
    {
        return 500;
    }
}

class Program
{
    static void Main()
    {
        Member s = new StudentMember();
        s.Name = "Raiyan";
        s.MemberId = 101;

        Member r = new RegularMember();
        r.Name = "Tashfiquee";
        r.MemberId = 102;

        Console.WriteLine("Student Fee: " + s.CalculateFee());
        Console.WriteLine("Regular Fee: " + r.CalculateFee());
    }
}