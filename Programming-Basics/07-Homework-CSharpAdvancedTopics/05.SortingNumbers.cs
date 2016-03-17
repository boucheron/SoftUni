using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbersArr = new int[n];
        int minPos = 0;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            numbersArr[i] = int.Parse(Console.ReadLine());
        }

        //Selection sort
        for (int i = 0; i < numbersArr.Length - 1; i++)
        {
            minPos = i;
            for (int j = i + 1; j < numbersArr.Length; j++)
            {
                if (numbersArr[minPos] > numbersArr[j])
                {
                    minPos = j;
                }
            }

            if (minPos != i)
            {
                temp = numbersArr[i];
                numbersArr[i] = numbersArr[minPos];
                numbersArr[minPos] = temp;
            }
        }

        Console.Clear();

        foreach (int a in numbersArr)
        {
            Console.WriteLine(a);
        }

    }
}