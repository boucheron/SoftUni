using System;

class LongestWordInText
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(" \t\r\n\x85\xA0.,;:!?()[]-\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        string maxWord = words[0];

        foreach (string word in words)
        {
            if (maxWord.Length < word.Length)
            {
                maxWord = word;
            }
        }

        Console.WriteLine(maxWord);

    }
}