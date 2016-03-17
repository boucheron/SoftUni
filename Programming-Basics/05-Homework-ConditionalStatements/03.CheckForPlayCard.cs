using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("card sign: ");
        string cardSign = Console.ReadLine();

        switch (cardSign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": Console.WriteLine("Valid card sign? YES"); break;
            default: Console.WriteLine("Valid card sign? NO"); break;
        }

    }
}