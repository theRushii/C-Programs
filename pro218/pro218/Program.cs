using System;

class PowerCalculation
{
    // Calculates power of a number
    static void Main()
    {
        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exp = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= exp; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine("Result = " + result);
    }
}