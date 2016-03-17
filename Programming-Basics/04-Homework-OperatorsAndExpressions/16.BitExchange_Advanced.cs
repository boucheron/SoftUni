using System;

class BitExchange_Advanced
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (p > q)
        {
            int temp = p;
            p = q;
            q = temp;
        }

        if (Math.Abs(q - p) < Math.Abs(k))
        {
            Console.WriteLine("overlapping");
        }
        else if (Math.Max(p, q) + k > 32 || Math.Min(p, q) < 0 || Math.Min(p, q) + k < 1)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {            
                uint pBit = (n >> (p + i)) & 1;
                long maskP = 1 << (p + i);
                uint qBit = (n >> (q + i)) & 1;
                long maskQ = 1 << (q + i);

                if (pBit != qBit)
                {
                    if (pBit == 0)
                    {
                        n = n ^ (uint)maskQ;
                    }
                    else
                    {
                        n = n | (uint)maskQ;
                    }

                    if (qBit == 0)
                    {
                        n = n ^ (uint)maskP;
                    }
                    else
                    {
                        n = n | (uint)maskP;
                    }
                }     
            }

            Console.WriteLine(n);
        }

    }
}