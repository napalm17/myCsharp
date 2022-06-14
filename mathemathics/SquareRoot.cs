using System;

namespace mathemathics
{
    public class SquareRoot
    {
        public static double FirstEstimate(int s)
        {
            int x0 = 1;
            for (int i = 1; i < s; i++)
            {
                if (i * i >= s)
                {
                    x0 = i;
                    break;
                }
            }
            return BabylonianMethod(s, x0);
        }
        static double BabylonianMethod(int s, double x0=1)
        {
            double x1 = 0.5 * (x0 + (s / x0));
            if (x0 == x1)
            {
                return x1;
            }
            return BabylonianMethod(s, x1);
        }   
    }
}