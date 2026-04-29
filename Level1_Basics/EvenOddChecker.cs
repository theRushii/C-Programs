using System;

namespace CPrograms
{
    // Determines whether a given integer is even or odd.
    class EvenOddChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                    Console.WriteLine($"{number} is even.");
                else
                    Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
