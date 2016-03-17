using System;

class NumbersInIntervalDividableByNumber
{
    static void Main()
    {
        Console.Write("start: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("end: ");
        int endNum = int.Parse(Console.ReadLine());
        int pNum = (endNum / 5) - (startNum / 5);

        if (startNum % 5 == 0)
        {
            pNum++;
        }

        Console.WriteLine("The numbers in interval ({0},{1}) dividable by 5 are {2}.", startNum, endNum, pNum);

    }
}