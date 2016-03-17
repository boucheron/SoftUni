using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e: ");
        double e = double.Parse(Console.ReadLine());
        double biggest = double.MinValue;

        if (a >= b && a >= c && a >= d && a >= e)
        {
            biggest = a;
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            biggest = b;
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            biggest = c;
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            biggest = d;
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            biggest = e;
        }

        if (a == b && b == c && c == d && d == e)
        {
            Console.WriteLine("Equality!");
        }
        else
        {
            Console.WriteLine("The biggest is {0}", biggest);
        }

    }
}