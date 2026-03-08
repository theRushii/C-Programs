using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int age;
            string city;
            string email;

            Console.Write("Enter your name: ");
            Name = Console.ReadLine();

            Console.Write("What is your age?: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your city: ");
            city = Console.ReadLine();

            Console.Write("Enter your email: ");
            email = Console.ReadLine();

            Console.WriteLine("\n--- User Details ---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Email: " + email);

            Console.ReadLine();
        }
    }
}