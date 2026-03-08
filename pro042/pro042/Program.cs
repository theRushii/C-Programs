using System;

class Program
{
    static void Main()
    {
        int days, years, months, remDays;

        Console.Write("Enter days: ");
        days = Convert.ToInt32(Console.ReadLine());

        years = days / 365;
        months = (days % 365) / 30;
        remDays = (days % 365) % 30;

        Console.WriteLine("Years = " + years);
        Console.WriteLine("Months = " + months);
        Console.WriteLine("Days = " + remDays);
    }
}