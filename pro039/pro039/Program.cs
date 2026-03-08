using System;

class Program
{
    static void Main()
    {
        double basic, hra, da, total;

        Console.Write("Enter basic salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        hra = basic * 0.2;
        da = basic * 0.1;
        total = basic + hra + da;

        Console.WriteLine("Total salary = " + total);
    }
}