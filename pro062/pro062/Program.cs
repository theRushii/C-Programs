using System;

class Program
{
    static void Main()
    {
        string str;
        int count = 0;

        Console.Write("Enter string: ");
        str = Console.ReadLine().ToLower();

        foreach (char c in str)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }

        Console.WriteLine("Vowels = " + count);
    }
}