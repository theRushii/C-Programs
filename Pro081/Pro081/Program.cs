using System;

class Program
{
    static void Display(int[] arr)
    {
        foreach (int i in arr)
            Console.WriteLine(i);
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Display(a);
    }
}