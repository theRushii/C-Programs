using System;

class Program
{
    static void Main()
    {
        string str;

        Console.Write("Enter string: ");
        str = Console.ReadLine();

        str = str.Replace(" ", "");

        Console.WriteLine("Result = " + str);
    }
}