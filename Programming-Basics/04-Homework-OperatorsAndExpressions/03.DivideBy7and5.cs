using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        bool isDividedBy7and5 = false;

        if (number != 0)
        {
            isDividedBy7and5 = number % 35 == 0;
        }
        
        Console.WriteLine("Divided by 7 and 5? {0}", isDividedBy7and5);

    }
}