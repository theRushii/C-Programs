using System;
using System.Linq;

class VowelCount
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();
        int count = 0;

        foreach (char c in str)
        {
            if ("aeiou".Contains(c))
                count++;
        }

        Console.WriteLine("Vowels: " + count);
    }
}