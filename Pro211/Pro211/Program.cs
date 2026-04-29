using System;

class ReverseNumber
{
    // Reverses a number
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int reverse = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("Reversed Number = " + reverse);
    }
}