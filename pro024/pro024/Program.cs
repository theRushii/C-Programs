using System;

class Program
{
    static void Main()
    {
        double l, b, area;

        Console.Write("Enter length: ");
        l = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth: ");
        b = Convert.ToDouble(Console.ReadLine());

        area = l * b;

        Console.WriteLine("Area of rectangle = " + area);
    }
}