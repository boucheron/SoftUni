using System;

class EmergencyRepairs
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int repairKits = int.Parse(Console.ReadLine());
        int attacks = int.Parse(Console.ReadLine());

        for (int i = 0; i < attacks; i++)
        {
            int attackedBit = int.Parse(Console.ReadLine());

            if (CheckBitAtPosition(number, attackedBit) == 1)
            {
                number = ChangeBitAtPosition(number, attackedBit);
            }
        }
     
        for (int i = 0; i < 64; i++)
        {
            if (CheckBitAtPosition(number, i) == 0 && CheckBitAtPosition(number, i + 1) == 0)
            { 
                while (repairKits > 0 && CheckBitAtPosition(number, i) == 0)
                {
                    number = ChangeBitAtPosition(number, i);

                    repairKits--;
                    i++;
                }       
            }
        }

        Console.WriteLine(number);

    }

    static int CheckBitAtPosition(ulong number, int position)
    {
        ulong mask = (ulong)1 << position;
        if ((number & mask) == 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    static ulong ChangeBitAtPosition(ulong number, int position)
    {
        ulong mask = (ulong)1 << position;
        number = number ^ mask;
        return number;
    }

}