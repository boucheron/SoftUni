using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Hexadecimal: ");
        string hexadecimalNumber = Console.ReadLine();
        long decimalNumber = 0;
        long hexPart = 0;

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            switch (hexadecimalNumber[i])
            {
                case 'A': hexPart = 10;
                    break;
                case 'B': hexPart = 11;
                    break;
                case 'C': hexPart = 12;
                    break;
                case 'D': hexPart = 13;
                    break;
                case 'E': hexPart = 14;
                    break;
                case 'F': hexPart = 15;
                    break;
                default: hexPart = (byte)Char.GetNumericValue(hexadecimalNumber[i]);
                    break;
            }

            for (int k = i; k < hexadecimalNumber.Length - 1; k++)
            {
                hexPart *= 16;
            }
            decimalNumber += hexPart;
        }

        Console.WriteLine("=> Decimal: {0}", decimalNumber);

    }
}