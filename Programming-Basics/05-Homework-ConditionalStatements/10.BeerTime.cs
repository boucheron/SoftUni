using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime inputTime;
        DateTime beerAfter = DateTime.Parse("01:00 PM");
        DateTime beerBefore = DateTime.Parse("03:00 AM");

        if (DateTime.TryParseExact(input, "hh:mm tt", CultureInfo.InvariantCulture, 
            DateTimeStyles.None, out inputTime))
        {
            if (beerAfter <= inputTime || inputTime < beerBefore)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time!");
        }   

    }
}