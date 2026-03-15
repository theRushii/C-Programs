using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Array.Sort(arr);

        Console.WriteLine(arr[arr.Length - 2]);
    }
}
