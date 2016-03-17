using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] integersArr = Console.ReadLine().Split(' ');
        int oddProduct = int.Parse(integersArr[0]);
        int evenProduct = int.Parse(integersArr[1]);

        for (int i = 2; i < integersArr.Length; i += 2)
        {
            oddProduct *= int.Parse(integersArr[i]);

            if (i != integersArr.Length - 1)
            {
                evenProduct *= int.Parse(integersArr[i + 1]);
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("YES\nproduct = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("NO\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
        }

    }
}