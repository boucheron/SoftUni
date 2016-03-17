using System;

class ZeroSubset
{
    static void Main()
    {
        string[] data = Console.ReadLine().Split();
        int a = int.Parse(data[0]);
        int b = int.Parse(data[1]);
        int c = int.Parse(data[2]);
        int d = int.Parse(data[3]);
        int e = int.Parse(data[4]);
        bool isNotZeroSub = true;

        if (a == 0)
        {
            Console.WriteLine(a);
            isNotZeroSub = false;
        }
        if (b == 0)
        {
            Console.WriteLine(a);
            isNotZeroSub = false;
        }
        if (c == 0)
        {
            Console.WriteLine(a);
            isNotZeroSub = false;
        }
        if (d == 0)
        {
            Console.WriteLine(a);
            isNotZeroSub = false;
        }
        if (e == 0)
        {
            Console.WriteLine(a);
            isNotZeroSub = false;
        }
        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            isNotZeroSub = false;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            isNotZeroSub = false;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            isNotZeroSub = false;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            isNotZeroSub = false;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            isNotZeroSub = false;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            isNotZeroSub = false;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            isNotZeroSub = false;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            isNotZeroSub = false;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            isNotZeroSub = false;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            isNotZeroSub = false;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            isNotZeroSub = false;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            isNotZeroSub = false;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            isNotZeroSub = false;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            isNotZeroSub = false;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            isNotZeroSub = false;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            isNotZeroSub = false;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            isNotZeroSub = false;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            isNotZeroSub = false;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            isNotZeroSub = false;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            isNotZeroSub = false;
        }
        if (a + b + c == 0 && d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            isNotZeroSub = false;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            isNotZeroSub = false;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            isNotZeroSub = false;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            isNotZeroSub = false;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            isNotZeroSub = false;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            isNotZeroSub = false;
        }

        if (isNotZeroSub)
        {
            Console.WriteLine("no zero subset");
        }

    }
}