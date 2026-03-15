using System;

class Program
{
    static void Main()
    {
        string a = "listen";
        string b = "silent";

        char[] c1 = a.ToCharArray();
        char[] c2 = b.ToCharArray();

        Array.Sort(c1);
        Array.Sort(c2);

        if (new string(c1) == new string(c2))
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not Anagram");
    }
}