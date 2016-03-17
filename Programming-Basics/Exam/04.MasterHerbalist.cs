using System;

class MasterHerbalist
{
    static void Main()
    {
        int dailyExp = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        int days = 0;
        int totalMoney = 0;

        while (command != "Season Over")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            int hours = int.Parse(command.Split()[0]);
            string path = command.Split()[1];
            int price = int.Parse(command.Split()[2]);

            for (int i = 0, j = 0; i < hours; i++, j++)
            {
                if (j >= path.Length)
                {
                    j = 0;
                }

                if (path[j] == 'H')
                {
                    totalMoney += price;
                }
            }

            days++;
            command = Console.ReadLine();
        }

        double avgEarning = (double)totalMoney / days;

        if (avgEarning >= dailyExp)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", avgEarning - dailyExp);
        }
        else
        {
            Console.WriteLine("We are in the red. Money needed: {0}.", (dailyExp * days) - totalMoney);
        }

    }
}