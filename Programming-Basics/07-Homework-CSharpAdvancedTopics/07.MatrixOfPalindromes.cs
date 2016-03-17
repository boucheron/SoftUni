using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] rowAndCol = input.Split(' ');
        int rows = int.Parse(rowAndCol[0]);
        int cols = int.Parse(rowAndCol[1]);
        char letter;
        char letterMiddle;

        for (int i = 0; i < rows; i++)
        {
            letter = (char)(97 + i);
            for (int j = 0; j < cols; j++)
            {
                letterMiddle = (char)(97 + j + i);
                Console.Write("{0}{1}{0} ", letter, letterMiddle);
            }
            Console.WriteLine();
        }

    }
}