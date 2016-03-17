using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 100)
        {
            BigInteger numerator = 1;
            BigInteger divisor = 1;

            for (int i = n + 2; i <= 2 * n; i++)
            {
                numerator *= i;
            }
            for (int i = 2; i <= n; i++)
            {
                divisor *= i;
            }

            BigInteger result = numerator / divisor;
            Console.WriteLine("Catalan({0}) = {1}", n, result);
        }
        else
        {
            Console.WriteLine("Please, enter a number in the range (1 < n < 100)!");
        }
        
    }
}