using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your date of birth: ");
        DateTime bDay = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Now.Year - bDay.Year;

        if (bDay.DayOfYear > DateTime.Now.DayOfYear)
        {
            age--;
        }

        Console.WriteLine("Now: " + age);
        Console.WriteLine("After 10 years: " + (age + 10));

    }
}