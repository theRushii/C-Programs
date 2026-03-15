using System;

class Program
{
    static void Show(string name, int age)
    {
        Console.WriteLine(name + " " + age);
    }

    static void Main()
    {
        Show(age: 21, name: "Ravi");
    }
}