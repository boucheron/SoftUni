using System;

class RandomizeTheNumbers1toN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numArray = new int[n];
        Random randNumArray = new Random();

        for (int i = 0; i < n; i++)
        {
            numArray[i] = i + 1;
        }

        for (int i = 0; i < n; i++)
        {
            int first = randNumArray.Next(n);
            int second = randNumArray.Next(n);
            int temp = numArray[first];
            numArray[first] = numArray[second];
            numArray[second] = temp;
        }

        Console.WriteLine("Randomized numbers 1...{0}:", n);
        foreach (int a in numArray)
        {
            Console.Write(a + " ");
        }

    }
}