using System;

class Program
{
    static void Main()
    {
        int n, sum = 0;

        Console.Write("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            sum = sum + i;

        Console.WriteLine("Sum = " + sum);
    }
}