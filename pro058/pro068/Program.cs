using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.Write("Enter number to search: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (int i in arr)
        {
            if (i == num)
                found = true;
        }

        if (found)
            Console.WriteLine("Element found");
        else
            Console.WriteLine("Element not found");
    }
}