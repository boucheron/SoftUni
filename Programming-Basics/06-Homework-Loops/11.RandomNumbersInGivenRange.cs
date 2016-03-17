using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
        {
            Random randNumber = new Random();
            Console.Write("Random numbers: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(randNumber.Next(min, max + 1) + " ");
            }
        }
        else
        {
            Console.WriteLine("Error: max < min!");
        }

    }
}