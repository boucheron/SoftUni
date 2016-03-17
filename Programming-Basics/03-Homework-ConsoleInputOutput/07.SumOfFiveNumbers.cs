using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("5 numbers: ");
        string numbers = Console.ReadLine();
        string[] numbersArr = numbers.Split(' ');
        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(numbersArr[i]);
        }

        Console.WriteLine("Sum: {0}", sum);

    }
}