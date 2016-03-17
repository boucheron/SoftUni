using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        List<string> firstNames = new List<string>(names);
        names = Console.ReadLine().Split(' ');
        List<string> secondNames = new List<string>(names);

        foreach (string s in secondNames)
        {
            if (firstNames.Contains(s))
            {
                firstNames.RemoveAll(name => name == s);
            }
        }

        foreach (string name in firstNames)
        {
            Console.Write(name + " ");
        }

    }
}