using System;

class CountDigits
{
    // Counts digits in a number
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int count = 0;

        while (num != 0)
        {
            num /= 10;
            count++;
        }

        Console.WriteLine("Total digits = " + count);
    }
}