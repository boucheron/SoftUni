using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n (n <= 100): ");
        int number = int.Parse(Console.ReadLine());
        int nSqrt = (int)Math.Sqrt(number);
        int divider = 2;
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            while (isPrime && (divider <= nSqrt))
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
        }
        
        Console.WriteLine("Prime? {0}", isPrime);

    }
}