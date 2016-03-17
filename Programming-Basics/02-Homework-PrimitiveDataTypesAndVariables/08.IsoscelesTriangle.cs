using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char c = '\u00A9';

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("{0,4}", c);
        Console.WriteLine();
        Console.WriteLine("{0,3}{0,2}", c);
        Console.WriteLine();
        Console.WriteLine("{0,2}{0,4}", c);
        Console.WriteLine();
        Console.WriteLine("{0,1}{0,2}{0,2}{0,2}", c);

    }
}