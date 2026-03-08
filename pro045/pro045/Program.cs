using System;

enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

class Program
{
    static void Main()
    {
        Days d = Days.Wednesday;
        Console.WriteLine(d);
    }
}