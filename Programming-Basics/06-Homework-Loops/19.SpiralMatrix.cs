using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 21)
        {
            int[,] spiral = new int[n, n];
            int start = 0;
            int end = n;
            int digit = 1;

            while (end - start >= 1)
            {
                for (int p = start; p < end; p++)
                {
                    spiral[start, p] = digit;
                    digit++;
                }
                for (int q = start + 1; q < end; q++)
                {
                    spiral[q, end - 1] = digit;
                    digit++;
                }
                for (int r = end - 2; r >= start; r--)
                {
                    spiral[end - 1, r] = digit;
                    digit++;
                }
                for (int s = end - 2; s >= start + 1; s--)
                {
                    spiral[s, start] = digit;
                    digit++;
                }
                start++;
                end--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(" {0,3}", spiral[i, k]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please, enter a integer in the range (1 <= n <= 20)!");
        }

    }
}