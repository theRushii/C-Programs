using System;

class LCM
{
    // Finds LCM of two numbers
    static void Main()
    {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int max = Math.Max(a, b);

        while (true)
        {
            if (max % a == 0 && max % b == 0)
            {
                Console.WriteLine("LCM = " + max);
                break;
            }
            max++;
        }
    }
}