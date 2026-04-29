using System;

class SwapNumbers
{
    // This program swaps two numbers
    static void Main()
    {
        int a = 5, b = 10;

        Console.WriteLine($"Before Swap: a = {a}, b = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After Swap: a = {a}, b = {b}");
    }
}