using System;

class MinMaxSumAndAvgOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }

        double avg = 0;
        avg = (double)sum / (double)n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:f2}", min, max, sum, avg);

    }
}