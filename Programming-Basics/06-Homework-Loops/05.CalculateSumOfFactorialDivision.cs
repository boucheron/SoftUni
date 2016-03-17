using System;

class CalculateSumOfFactorialDivision
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        decimal nFactoriel = 1;
        decimal xPower = 1;
        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
            xPower *= x;
            sum += nFactoriel / xPower;
        }

        Console.WriteLine("S = {0:f5}", sum);

    }
}