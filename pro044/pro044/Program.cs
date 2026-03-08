using System;

class Program
{
    static void Main()
    {
        var a = 10;
        var b = "Hello";

        dynamic x = 20;
        x = "Dynamic variable";

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(x);
    }
}