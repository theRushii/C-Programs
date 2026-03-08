using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;

        Console.WriteLine("Enter 5 elements:");

        for (int i = 0; i < 5; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 5; i++)
            sum += arr[i];

        double avg = (double)sum / 5;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + avg);
    }
}