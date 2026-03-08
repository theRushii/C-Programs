using System;

class Program
{
    static void Main()
    {
        int choice;

        Console.Write("Enter number (1-3): ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}