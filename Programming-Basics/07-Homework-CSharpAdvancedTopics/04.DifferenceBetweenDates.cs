using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("First date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        TimeSpan diffDate = secondDate.Subtract(firstDate);

        if (diffDate < TimeSpan.Zero)
        {
            Console.WriteLine("Days between: -{0}", diffDate.ToString("%d"));
        }
        else
        {
            Console.WriteLine("Days between: {0}", diffDate.ToString("%d"));
        }

    }
}