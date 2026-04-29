using System;

class GCD
{
    // Finds GCD using Euclidean algorithm
    static void Main()
    {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine("GCD = " + a);
    }
}