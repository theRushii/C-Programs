using System;

class Program
{
    static void Main()
    {
        string str;

        Console.Write("Enter string: ");
        str = Console.ReadLine();

        string result = str.Replace("old", "new");

        Console.WriteLine(result);
    }
}