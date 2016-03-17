using System;
using System.Linq;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
        List<int> firstNumbers = new List<int>(numbers);
        numbers = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
        List<int> secondNumbers = new List<int>(numbers);
        
        List<int> joinedNumbers = firstNumbers.Union(secondNumbers).ToList();
        joinedNumbers.Sort();

        foreach(int number in joinedNumbers)
        {
            Console.Write(number + " ");
        }

    }
}