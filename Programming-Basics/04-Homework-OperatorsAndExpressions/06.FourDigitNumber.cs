using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int part4 = number % 10;
        number /= 10;
        int part3 = number % 10;
        number /= 10;
        int part2 = number % 10;
        number /= 10;
        int part1 = number % 10;

        Console.WriteLine("Sum of digits: {0}", (part1 + part2 + part3 + part4));
        Console.WriteLine("Reversed: {3}{2}{1}{0}", part1, part2, part3, part4);
        Console.WriteLine("Last digit in front: {3}{0}{1}{2}", part1, part2, part3, part4);
        Console.WriteLine("Second and third digits exchanged: {0}{2}{1}{3}", part1, part2, part3, part4);

    }
}