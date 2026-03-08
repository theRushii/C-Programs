using System;

class Program
{
    static void Main()
    {
        double r, area;

        Console.Write("Enter radius: ");
        r = Convert.ToDouble(Console.ReadLine());

        area = 3.14 * r * r;

        Console.WriteLine("Area of circle = " + area);
    }
}