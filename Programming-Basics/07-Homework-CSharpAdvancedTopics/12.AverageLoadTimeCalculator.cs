using System;
using System.Collections.Generic;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        Dictionary<string, List<double>> loadTimeData = new Dictionary<string, List<double>>();

        while (input.Length > 1)
        {
            string webSite = input[2];
            double loadTime = double.Parse(input[3]);

            if (loadTimeData.ContainsKey(webSite))
            {
                loadTimeData[webSite].Add(loadTime);
            }
            else
            {
                loadTimeData.Add(webSite, new List<double> { loadTime });
            }

            input = Console.ReadLine().Split(' ');
        }

        foreach (KeyValuePair<string, List<double>> a in loadTimeData)
        {
            double totalLoadTime = 0.0;
            for (int i = 0; i < a.Value.Count; i++)
            {
                totalLoadTime += a.Value[i];
            }

            Console.WriteLine("{0} -> {1}", a.Key, totalLoadTime / a.Value.Count);
        }

    }
}