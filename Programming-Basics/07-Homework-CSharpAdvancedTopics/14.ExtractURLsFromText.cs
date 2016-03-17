using System;

class ExtractURLsFromText
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        char[] trimChars = { ' ', ',', '.', '?', '!', ';', '"', '(', ')', '[', ']' };

        foreach (string s in text)
        {
            if (s.Contains("http://") || s.Contains("www."))
            {
                Console.WriteLine(s.Trim(trimChars));
            }
        }

    }
}