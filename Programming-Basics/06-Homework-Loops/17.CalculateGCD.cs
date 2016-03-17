using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        Console.Write("b = ");
        int b = Math.Abs(int.Parse(Console.ReadLine()));
        int temp;
        Console.Write("GCD({0}, {1}) = ", a, b);

        //Euclid's Algorithm
        while (a != 0)
        {
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            a %= b;
        }

        Console.WriteLine(b);

    }
}