using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Binary: ");
        string binaryNumber = Console.ReadLine();
        long decimalNumber = (byte)Char.GetNumericValue(binaryNumber[0]);

        //Horner's Method
        for (int i = 1; i < binaryNumber.Length; i++)
        {
            decimalNumber *= 2;
            decimalNumber += (byte)Char.GetNumericValue(binaryNumber[i]);
        }

        Console.WriteLine("=> Decimal: {0}", decimalNumber);

    }
}