using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;

        Console.WriteLine("Rectangle's perimeter is {0:f2}, and the area is {1:f2}.", perimeter, area);

    }
}