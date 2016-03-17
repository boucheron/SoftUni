using System;
using System.Text;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a whole number in the range [0..999]: ");
        int number = int.Parse(Console.ReadLine());

        while (number < 0 || number > 999)
        {
            Console.WriteLine("Numeric value out of the range!");
            number = int.Parse(Console.ReadLine());
        }

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int ones = number % 10;
        StringBuilder numAsWords = new StringBuilder();

        switch (hundreds)
        {
            case 1: numAsWords.Append("one hundred"); break;
            case 2: numAsWords.Append("two hundred"); break;
            case 3: numAsWords.Append("three hundred"); break;
            case 4: numAsWords.Append("four hundred"); break;
            case 5: numAsWords.Append("five hundred"); break;
            case 6: numAsWords.Append("six hundred"); break;
            case 7: numAsWords.Append("seven hundred"); break;
            case 8: numAsWords.Append("eight hundred"); break;
            case 9: numAsWords.Append("nine hundred"); break;
            default: break;
        }

        if (hundreds != 0 && tens != 0)
        {
            numAsWords.Append(" and ");
        }

        switch (tens)
        {
            case 1:
                switch (ones)
                {
                    case 0: numAsWords.Append("ten"); break;
                    case 1: numAsWords.Append("eleven"); break;
                    case 2: numAsWords.Append("twelve"); break;
                    case 3: numAsWords.Append("thirteen"); break;
                    case 4: numAsWords.Append("fourteen"); break;
                    case 5: numAsWords.Append("fifteen"); break;
                    case 6: numAsWords.Append("sixteen"); break;
                    case 7: numAsWords.Append("seventeen"); break;
                    case 8: numAsWords.Append("eighteen"); break;
                    case 9: numAsWords.Append("nineteen"); break;
                    default: break;
                }
                break;
            case 2: numAsWords.Append("twenty"); break;
            case 3: numAsWords.Append("thirty"); break;
            case 4: numAsWords.Append("forty"); break;
            case 5: numAsWords.Append("fifty"); break;
            case 6: numAsWords.Append("sixty"); break;
            case 7: numAsWords.Append("seventy"); break;
            case 8: numAsWords.Append("eighty"); break;
            case 9: numAsWords.Append("ninety"); break;
            default: break;

        }

        if (tens > 1 && ones != 0)
        {
            numAsWords.Append("-");
        }
        else if (hundreds != 0 && tens == 0 && ones != 0)
        {
            numAsWords.Append(" and ");
        }

        if (tens != 1)
        {
            switch (ones)
            {
                case 1: numAsWords.Append("one"); break;
                case 2: numAsWords.Append("two"); break;
                case 3: numAsWords.Append("three"); break;
                case 4: numAsWords.Append("four"); break;
                case 5: numAsWords.Append("five"); break;
                case 6: numAsWords.Append("six"); break;
                case 7: numAsWords.Append("seven"); break;
                case 8: numAsWords.Append("eight"); break;
                case 9: numAsWords.Append("nine"); break;
                default: break;
            }

        }

        if (hundreds == 0 && tens == 0 && ones == 0)
        {
            numAsWords.Append("zero");
        }

        numAsWords[0] = Char.ToUpper(numAsWords[0]);
        Console.WriteLine(numAsWords);

    }
}