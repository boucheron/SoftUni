using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Decimal: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string hexadecimalNumber = string.Empty;
        long remainder = 0L;

        while (decimalNumber != 0)
        {
            remainder = decimalNumber % 16;
            switch (remainder)
            {
                case 10: hexadecimalNumber = 'A' + hexadecimalNumber; break;
                case 11: hexadecimalNumber = 'B' + hexadecimalNumber; break;
                case 12: hexadecimalNumber = 'C' + hexadecimalNumber; break;
                case 13: hexadecimalNumber = 'D' + hexadecimalNumber; break;
                case 14: hexadecimalNumber = 'E' + hexadecimalNumber; break;
                case 15: hexadecimalNumber = 'F' + hexadecimalNumber; break;
                default: hexadecimalNumber = remainder + hexadecimalNumber; break;
            }
            decimalNumber /= 16;
        }

        Console.WriteLine("=> Hexadecimal: {0}", hexadecimalNumber);

    }
}