using System;

class SimpleInterest
{
    // This program calculates simple interest
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double t = double.Parse(Console.ReadLine());

        double si = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}