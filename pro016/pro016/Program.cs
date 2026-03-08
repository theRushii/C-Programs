using System;

class Program
{
    static void Main()
    {
        int num, sum = 0;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}