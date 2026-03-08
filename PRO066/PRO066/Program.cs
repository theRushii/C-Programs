using System;

class Program
{
    static void Main()
    {
        string str;

        Console.Write("Enter string: ");
        str = Console.ReadLine();

        foreach (char c in str)
        {
            int count = 0;

            foreach (char x in str)
            {
                if (c == x)
                    count++;
            }

            Console.WriteLine(c + " : " + count);
        }
    }
}