using System;

class Program
{
    static void Main()
    {
        int baseNum, exp;
        double result;

        Console.Write("Enter base: ");
        baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        exp = Convert.ToInt32(Console.ReadLine());

        result = Math.Pow(baseNum, exp);

        Console.WriteLine("Result = " + result);
    }
}