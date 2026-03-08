using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 elements:");

        for (int i = 0; i < 5; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < 5; i++)
        {
            if (arr[i] > max)
                max = arr[i];

            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine("Largest = " + max);
        Console.WriteLine("Smallest = " + min);
    }
}