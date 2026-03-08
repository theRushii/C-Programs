using System;

class Program
{
    static void Main()
    {
        int num, sum = 0, temp;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;

        while (num != 0)
        {
            int rem = num % 10;
            sum = sum + rem * rem * rem;
            num = num / 10;
        }

        if (sum == temp)
            Console.WriteLine("Armstrong number");
        else
            Console.WriteLine("Not Armstrong number");
    }
}