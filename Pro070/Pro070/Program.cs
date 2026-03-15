using System;

class Program
{
    static void Main()
    {
        string a, b;

        Console.Write("Enter first string: ");
        a = Console.ReadLine();

        Console.Write("Enter second string: ");
        b = Console.ReadLine();

        if (a == b)
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");
    }
}