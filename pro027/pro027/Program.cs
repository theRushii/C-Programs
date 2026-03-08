using System;

class Program
{
    readonly int x = 10;
    const double pi = 3.14;

    static void Main()
    {
        Program obj = new Program();
        Console.WriteLine(obj.x);
        Console.WriteLine(pi);
    }
}