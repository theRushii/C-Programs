using System;

class Program
{
    static void Main()
    {
        int num;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positive");
        else
            Console.WriteLine("Negative");
    }
}