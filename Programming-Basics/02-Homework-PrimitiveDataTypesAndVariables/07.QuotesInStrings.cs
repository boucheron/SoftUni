using System;

class QuotesInStrings
{
    static void Main()
    {
        string quotedNo = "The \"use\" of quotations causes difficulties.";
        string quotedYes = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotedNo);
        Console.WriteLine(quotedYes);

    }
}