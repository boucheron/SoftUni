using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Decimal: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string binaryNumber = string.Empty;
        long remainder = 0;

        while (decimalNumber != 0)
        {
            remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        Console.WriteLine("=> Binary: {0}", binaryNumber);

    }
}