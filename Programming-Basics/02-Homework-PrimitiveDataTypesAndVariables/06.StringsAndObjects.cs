using System;

class StringsAndObjects
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        object newObject = str1 + " " + str2;
        string str3 = (string)newObject;

        Console.WriteLine(newObject);
        Console.WriteLine(str3);

    }
}