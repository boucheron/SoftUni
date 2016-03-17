using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("n = ");
        uint number = uint.Parse(Console.ReadLine());

        number = ExchangeBits(number, 3, 24);
        number = ExchangeBits(number, 4, 25);
        number = ExchangeBits(number, 5, 26);

        Console.WriteLine("Result: {0}", number);

    }

    static uint ExchangeBits(uint number, byte bitFirst, byte bitSecond)
    {
        uint bitAtFirstPos = (number >> bitFirst) & 1;
        uint bitAtSecondPos = (number >> bitSecond) & 1;

        if (bitAtFirstPos != bitAtSecondPos)
        {
            if (bitAtFirstPos == 1)
            {
                number = number ^ (uint)(1 << bitFirst);
                number = number | (uint)(1 << bitSecond);
            }
            else
            {
                number = number ^ (uint)(1 << bitSecond);
                number = number | (uint)(1 << bitFirst);
            }
        }

        return number; 
    }

}