using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h: ");
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = (a + b) * h * 0.5;

        Console.WriteLine("Trapezoid area is {0}.", trapezoidArea);

    }
}