using System;

class ComparingFloats
{
    static void Main()
    {
        double numberA = -0.0000007;
        double numberB = 0.00000007;
        double eps = 0.000001;
        double difference = Math.Abs(numberA - numberB);

        if (difference < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

    }
}