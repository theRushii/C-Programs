using System;

class Program
{
    static void Test(ref int a, out int b)
    {
        a = a + 5;
        b = 20;
    }

    static void Main()
    {
        int x = 10;
        int y;

        Test(ref x, out y);

        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}