using System;

class TrailingZeroesInFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int counterZero = 0;
        int divider = 5;

        do
        {
            counterZero += n / divider;
            divider *= 5;
        }
        while (n / divider > 0);

        Console.WriteLine("Trailing zeroes in the {0}! are {1}.", n, counterZero);

    }
}