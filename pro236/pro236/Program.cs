using System;

class EvenOdd
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
    }
}