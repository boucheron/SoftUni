using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        int nMovedRight = n >> p;
        int endBit = nMovedRight & 1;
        bool isBit1 = endBit == 1;

        Console.WriteLine("Bit #{0} == 1? {1}", p, isBit1);

    }
}