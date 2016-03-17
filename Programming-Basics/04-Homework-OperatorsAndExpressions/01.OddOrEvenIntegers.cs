using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        bool oddOrEven = number % 2 != 0;

        Console.WriteLine("Odd?: {0}", oddOrEven);

    }
}