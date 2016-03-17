using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? number1 = null;
        double? number2 = null;
        Console.WriteLine(number1 + " " + number2);

        number1 += 1;
        number2 += 1;
        Console.WriteLine(number1 + " " + number2);

        number1 += null;
        number2 += null;
        Console.WriteLine(number1 + " " + number2);

    }
}