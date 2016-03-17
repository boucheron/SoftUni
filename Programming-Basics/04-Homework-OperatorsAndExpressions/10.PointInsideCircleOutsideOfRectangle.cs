using System;

class PointInsideCircleOutsideOfRectangle
{
    static void Main()
    {
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());

        string isInKOutR = "NO";
        bool isInsideCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) < 2.25;

        if (isInsideCircle && y > 1)
        {
            isInKOutR = "YES";
        }

        Console.WriteLine("Inside K & outside of R? {0}", isInKOutR);

    }
}