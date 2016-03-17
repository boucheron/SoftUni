using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;

        if (a != 0)
        {
            if (d == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("One double root: x1=x2={0:f2}", x1);
            }
            else if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Two roots: x1={0:f2} and x2={1:f2}", x1, x2);
            }
            else
            {
                Console.WriteLine("No real roots!");
            }
        }
        else
        {
            Console.WriteLine("Equation is linear!");
        }

    }
}