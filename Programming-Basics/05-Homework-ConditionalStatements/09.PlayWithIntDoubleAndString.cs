using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int" + "\n2 --> double" + "\n3 --> string");
        int choiceType = int.Parse(Console.ReadLine());

        switch (choiceType)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int numInt = int.Parse(Console.ReadLine());
                Console.WriteLine(numInt + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double numDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(numDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default:
                Console.WriteLine("Invalid value!");
                break;
        }

    }
}