using System;

class SumOfNnumbers
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} number: ", i);
            int nextNum = int.Parse(Console.ReadLine());
            sum += nextNum;
        }

        Console.WriteLine("Sum: {0}", sum);

    }
}