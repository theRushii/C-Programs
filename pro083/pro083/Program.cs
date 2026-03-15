using System;

class Program
{
    static void Main()
    {
        string str = "Hello world from C sharp";

        string[] words = str.Split(' ');

        foreach (string w in words)
            Console.WriteLine(w);
    }
}