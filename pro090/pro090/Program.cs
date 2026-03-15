using System;

class Sample
{
    int[] arr = new int[5];

    public int this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main()
    {
        Sample s = new Sample();

        s[0] = 10;
        s[1] = 20;

        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
    }
}