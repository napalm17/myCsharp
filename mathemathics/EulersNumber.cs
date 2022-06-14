using System;

namespace mathemathics
{
    public class EulersNumber
    {
        public static double Series(int range=1000, int x = 1)
        {
            double e = 0;
            double e1 = 3;
            for (int i = 0; i < range; i++)
            {
                e += (Math.Pow(x, i) / Factorial.Looped(i));
                if (e == e1)
                {
                    break;
                }
                e1 = e;
                System.Console.WriteLine(e);
            }
            return e;
        }
    }
}