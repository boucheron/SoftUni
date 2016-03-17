using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("First number = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Second number = ");
        int secondNum = int.Parse(Console.ReadLine());

        List<int> listOfPrimesInRange = FindPrimesInRange(firstNum, secondNum);
        PrintListOfIntegers(listOfPrimesInRange);

    }

    static List<int> FindPrimesInRange(int num1, int num2)
    {
        List<int> primesInRange = new List<int>();

        for (int i = num1; i <= num2; i++)
        {
            int nSqrt = (int)Math.Sqrt(i);
            int divider = 2;
            bool isPrime = true;

            while (divider <= nSqrt)
            {
                if (i % divider == 0)
                {
                    isPrime = false;
                    break;
                }
                divider++;
            }

            if(isPrime && i > 1)
            {
                primesInRange.Add(i);
            }
        }

        return primesInRange;
    }

    static void PrintListOfIntegers(List<int> numbers)
    {
            Console.Write(String.Join(", ", numbers.ToArray()));
    }
}