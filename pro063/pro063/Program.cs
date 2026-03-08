using System;

class Program
{
    static void Main()
    {
        string str, rev = "";

        Console.Write("Enter string: ");
        str = Console.ReadLine();

        for (int i = str.Length - 1; i >= 0; i--)
            rev += str[i];

        Console.WriteLine("Reversed string = " + rev);
    }
}