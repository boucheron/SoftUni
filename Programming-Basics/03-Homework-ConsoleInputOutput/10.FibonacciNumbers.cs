using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        decimal pre0 = 0m;
        decimal pre1 = 1m;
        decimal fiboMember = 0m;

        if (n > 2)
        {
            Console.Write(pre0 + " " + pre1 + " ");
            for (int i = 0; i < n - 2; i++)
            {
                fiboMember = pre0 + pre1;
                pre0 = pre1;
                pre1 = fiboMember;
                Console.Write(fiboMember + " ");
            }
        }
        else if (n == 1)
        {
            Console.Write(pre0);

        }
        else if (n == 2)
        {
            Console.Write(pre0 + " " + pre1);
        }

    }
}