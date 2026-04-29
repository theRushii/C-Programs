using System;

class SumOfTwoNumbers
{
    // This program adds two numbers
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum = " + (a + b));
    }
}