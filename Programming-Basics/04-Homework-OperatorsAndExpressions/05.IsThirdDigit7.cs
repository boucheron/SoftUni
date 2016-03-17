using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.Write("number: ");
        int number = int.Parse(Console.ReadLine());
        int extract7 = Math.Abs((number / 100) % 10);
        bool check7 = extract7 == 7;

        Console.WriteLine("Third digit 7? " + check7);

    }
}