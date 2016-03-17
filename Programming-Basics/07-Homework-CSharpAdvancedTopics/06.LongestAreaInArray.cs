using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        string[] strArr = new string[n];

        for (int i = 0; i < strArr.Length; i++)
        {
            strArr[i] = Console.ReadLine();
        }

        int counterMaxSeq = 1;
        int counterCurrentSeq = 1;
        int startMaxSeq = 0;

        for (int i = 0; i < strArr.Length - 1; i++)
        {
            if (strArr[i] == strArr[i + 1])
            {
                counterCurrentSeq++;
                if (counterCurrentSeq > counterMaxSeq)
                {
                    counterMaxSeq = counterCurrentSeq;
                    startMaxSeq = (i + 1) - (counterCurrentSeq - 1);
                }
            }
            else
            {
                counterCurrentSeq = 1;
            }
        }

        Console.WriteLine(counterMaxSeq);

        for (int i = 0; i < counterMaxSeq; i++)
        {
            Console.WriteLine(strArr[startMaxSeq + i]);
        }

    }
}