using System;

class BeerStock
{
    static void Main()
    {
        int beersReserved = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        long beersShiped = 0L;

        while (command != "Exam Over")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            int amount = int.Parse(command.Split()[0].ToString());
            string type = command.Split()[1];

            switch (type)
            {
                case "cases":
                    beersShiped += amount * 24L;
                    break;
                case "sixpacks":
                    beersShiped += amount * 6L;
                    break;
                default:
                    beersShiped += amount;
                    break;
            }

            command = Console.ReadLine();
        }

        long beersBroken = beersShiped / 100;
        beersShiped -= beersBroken;

        if (beersShiped >= beersReserved)
        {

            beersShiped -= beersReserved;
            long cases = beersShiped / 24;
            long sixpacks = (beersShiped % 24) / 6;
            long beers = (beersShiped % 24) % 6;
            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
        }
        else
        {
            int beersNeeded = beersReserved - (int)beersShiped;
            long cases = beersNeeded / 24;
            long sixpacks = (beersNeeded % 24) / 6;
            long beers = (beersNeeded % 24) % 6;
            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
        }

    }
}