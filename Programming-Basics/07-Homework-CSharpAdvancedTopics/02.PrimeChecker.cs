using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("n = ");
        long number = long.Parse(Console.ReadLine());
        bool checkPrime = false;

        if (number < 0)
        {
            Console.WriteLine("Please, enter a positive integer!");
            return;
        }

        if (number > 1)
        {
            checkPrime = IsPrime(number);
        }

        Console.WriteLine("Prime? {0}", checkPrime);

    }

    static bool IsPrime(long n)
    {
        int nSqrt = (int)Math.Sqrt(n);
        int divider = 2;
        bool isPrime = true;
        while (isPrime && (divider <= nSqrt))
        {
            if (n % divider == 0)
            {
                isPrime = false;
            }
            divider++;
        }
        return isPrime;
    }
}