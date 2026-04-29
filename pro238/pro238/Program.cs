using System;

class Palindrome
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int original = n, rev = 0;

        while (n > 0)
        {
            int rem = n % 10;
            rev = rev * 10 + rem;
            n /= 10;
        }

        Console.WriteLine(original == rev ? "Palindrome" : "Not Palindrome");
    }
}