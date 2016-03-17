using System;

class IlluminatiLock
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        string line = new String('.', n) + new String('#', n) + new String('.', n);
        Console.WriteLine(line);

        int outerDots = n - 2;
        int innerDots = 0;

        for (int i = 0; i < n / 2; i++)
        {
            line = new String('.', outerDots) + "##" + new String('.', innerDots) + "#" + new String('.', n - 2) + "#" + new String('.', innerDots) + "##" + new String('.', outerDots);
            Console.WriteLine(line);

            outerDots -= 2;
            innerDots += 2;
        }

        for (int i = 0; i < n / 2; i++)
        {
            outerDots += 2;
            innerDots -= 2;

            line = new String('.', outerDots) + "##" + new String('.', innerDots) + "#" + new String('.', n - 2) + "#" + new String('.', innerDots) + "##" + new String('.', outerDots);
            Console.WriteLine(line);        
        }

        line = new String('.', n) + new String('#', n) + new String('.', n);
        Console.WriteLine(line);

    }
}