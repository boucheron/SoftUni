using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();

        SortedDictionary<string, int> namesCounted = new SortedDictionary<string, int>();

        foreach(string name in names)
        {
            if (namesCounted.ContainsKey(name))
            {
                namesCounted[name]++;
            }
            else
            {
                namesCounted.Add(name, 1);
            }
        }

        foreach(KeyValuePair<string, int> name in namesCounted)
        {
            Console.WriteLine("{0} -> {1}", name.Key, name.Value);
        }

    }
}