using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n < 21)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,2}", i);
                for (int k = i + 1; k <= i + n - 1; k++)
                {
                    Console.Write("{0,3}", k);
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