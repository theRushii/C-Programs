using System;

class Program
{
    static void Main()
    {
        int num, rev = 0;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            int rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;
        }

        Console.WriteLine("Reversed number = " + rev);
    }
}