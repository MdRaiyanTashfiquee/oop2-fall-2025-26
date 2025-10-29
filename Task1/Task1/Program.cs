// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first student score : ");
int score1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second student score : ");
int score2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third student score : ");
int score3 = Convert.ToInt32(Console.ReadLine());

double average = (score1 + score2 + score3) / 3.0;
Console.WriteLine($"Average score : {average}");