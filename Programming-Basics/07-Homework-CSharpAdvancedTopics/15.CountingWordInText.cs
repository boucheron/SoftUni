using System;

class CountingWordInText
{
    static void Main()
    {
        string word = Console.ReadLine();
        string[] text = Console.ReadLine().Split(" /@\t\r\n\x85\xA0.,;:!?()[]-+*\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        int wordOccurrences = 0;

        foreach (string s in text)
        {
            if (s.Equals(word, StringComparison.CurrentCultureIgnoreCase))
            {
                wordOccurrences++;
            }
        }

        Console.WriteLine(wordOccurrences);

    }
}