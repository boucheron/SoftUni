using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Integer a (0 <= a <= 500): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Floating-point b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Floating-point c: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:f2}|{3,-10:f3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

    }
}