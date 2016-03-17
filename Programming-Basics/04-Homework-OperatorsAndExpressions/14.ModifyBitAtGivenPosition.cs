using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("number = ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("position = ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("bit value = ");
        byte bitValue = byte.Parse(Console.ReadLine());

        if (bitValue == 0)
        {
            //number = number & (~(1 << position));
            number = number ^ (1 << position);
        }
        else if (bitValue == 1)
        {
            number = number | (1 << position);
        }
        else
        {
            Console.WriteLine("Please, enter bit value 0 or 1!");
        }

        Console.WriteLine("\nResult: {0}", number);

    }
}