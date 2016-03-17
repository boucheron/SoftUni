using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("The radius of a circle: ");
        double radius = double.Parse(Console.ReadLine());
        double circlePerimeter = Math.PI * radius * 2;
        double circleArea = Math.PI * radius * radius;

        Console.WriteLine("The circle perimeter is {0:f2}, and area is {1:f2}.", circlePerimeter, circleArea);

    }
}