using System;

class Program
{
    static void Main()
    {
        string str;

        Console.Write("Enter string: ");
        str = Console.ReadLine();

        string[] words = str.Split(' ');

        Console.WriteLine("Word count = " + words.Length);
    }
}