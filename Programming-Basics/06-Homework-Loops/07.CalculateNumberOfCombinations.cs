using System;
using System.Numerics;

class CalculateNumberOfCombinations
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (1 < k && k < n && n < 100)
        {
            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;

            for (int i = k + 1; i <= n; i++)
            {
                nFactoriel *= i;
            }
            for (int i = 2; i <= n - k; i++)
            {
                kFactoriel *= i;
            }

            BigInteger result = nFactoriel / kFactoriel;
            Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
        }
        else
        {
            Console.WriteLine("Please, enter a integer in the range (1 < k < n < 100)!");
        }

    }
}