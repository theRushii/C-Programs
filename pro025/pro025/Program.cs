using System;

class Program
{
    static void Main()
    {
        char ch;

        Console.Write("Enter character: ");
        ch = Convert.ToChar(Console.ReadLine());

        int ascii = ch;

        Console.WriteLine("ASCII value = " + ascii);
    }
}