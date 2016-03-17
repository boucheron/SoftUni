using System;

class CakeTycoon
{
    static void Main()
    {
        ulong cakesWanted = ulong.Parse(Console.ReadLine());
        decimal flourPerCake = decimal.Parse(Console.ReadLine());
        uint flour = uint.Parse(Console.ReadLine());
        uint truffles = uint.Parse(Console.ReadLine());
        uint trufflePrice = uint.Parse(Console.ReadLine());

        double cakesProduced = Math.Floor(flour / (double)flourPerCake);

        if (cakesProduced >= cakesWanted)
        {
            ulong trufflesCost = (ulong)truffles * trufflePrice;
            double cakeCost = (trufflesCost / cakesWanted) * 1.25;
            Console.WriteLine("All products available, price of a cake: {0:F2}", cakeCost);
        }
        else
        {
            double flourNeeded = (cakesWanted * (double)flourPerCake) - flour;
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakesProduced, flourNeeded);
        }
 
    }
}