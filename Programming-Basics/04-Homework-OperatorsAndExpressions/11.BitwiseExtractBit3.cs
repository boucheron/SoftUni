using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());

        uint nMovedRight3bits = n >> 3;
        uint endBit = nMovedRight3bits & 1;

        Console.WriteLine("Bit #3 -> {0}", endBit);

    }
}