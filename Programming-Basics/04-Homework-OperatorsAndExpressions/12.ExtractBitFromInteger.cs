using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        int nMovedRight = n >> p;
        int endBit = nMovedRight & 1;

        Console.WriteLine("Bit #{0} -> {1}", p, endBit);

    }
}