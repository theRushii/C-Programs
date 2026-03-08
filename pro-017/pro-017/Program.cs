using System;

class Program
{
    static void Main()
    {
        int num, count = 0;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            num = num / 10;
            count++;
        }

        Console.WriteLine("Number of digits = " + count);
    }
}