using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());
        bool isInsideCircle = false;

        if (x * x + y * y < 4)
        {
            isInsideCircle = true;
        }

        Console.WriteLine("Inside the Circle? {0}", isInsideCircle);

    }
}