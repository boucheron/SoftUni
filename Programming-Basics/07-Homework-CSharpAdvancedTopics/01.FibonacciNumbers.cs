using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        //Beginning with F(0) = 1 and F(1) = 1;
        Console.Write("n = ");
        int num = int.Parse(Console.ReadLine());
        BigInteger fiboNum = 1;

        if (num < 0)
        {
            Console.WriteLine("Please, enter a positive integer!");
            return;
        }

        if (num > 1)
        {
            fiboNum = Fib(num);
        }

        Console.WriteLine("Fib({0}) = {1}", num, fiboNum);

    }

    static BigInteger Fib(int n)
    {
        BigInteger fiboPrev1 = 1;
        BigInteger fiboPrev2 = 1;
        BigInteger fiboNumber = 0;
        for (int i = 0; i <= n - 2; i++)
        {
            fiboNumber = fiboPrev1 + fiboPrev2;
            fiboPrev1 = fiboPrev2;
            fiboPrev2 = fiboNumber;
        }
        return fiboNumber;
    }
}