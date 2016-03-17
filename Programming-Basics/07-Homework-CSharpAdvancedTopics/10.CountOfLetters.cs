using System;
using System.Linq;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        char[] letters = Console.ReadLine().Split(' ').Select(c => Convert.ToChar(c)).ToArray();

        SortedDictionary<char, int> lettersCounted = new SortedDictionary<char, int>();

        foreach (char c in letters)
        {
            if (lettersCounted.ContainsKey(c))
            {
                lettersCounted[c] += 1;
            }
            else
            {
                lettersCounted.Add(c, 1);
            }
        }

        foreach (KeyValuePair<char, int> a in lettersCounted)
        {
            Console.WriteLine("{0} -> {1}", a.Key, a.Value);
        }

    }
}