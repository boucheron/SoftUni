using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("a: ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = int.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("a + b + c = {0}", sum);

    }
}