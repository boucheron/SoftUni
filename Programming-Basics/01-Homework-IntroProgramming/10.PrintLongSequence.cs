using System;

class PrintLongSequence
{
    static void Main()
    {
        int members = 1000;

        for (int i = 2; i < members; i += 2)
        {
            Console.Write("{0},-{1},", i, i + 1);
        }

        Console.Write("{0},-{1}", members, members + 1);

    }
}