using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Not a positive integer!");
        }

    }
}