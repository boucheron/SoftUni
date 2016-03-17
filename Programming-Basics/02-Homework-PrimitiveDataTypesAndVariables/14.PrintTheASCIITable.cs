using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        char symbol = '\u0000';
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 33; i <= 126; i++)
        {
            symbol = (char)i;
            Console.WriteLine(symbol);
        }

    }
}