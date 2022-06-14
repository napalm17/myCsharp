using System;

namespace mathemathics
{
    public class Logarithm
    {
        public static double Ln(double y, int range=1000000)
        {
            double sum = 0; 
            double sumControl = -1;
            double x = 1 - y;
            int coeff = 1;

            if (y == 0)
            {
                return double.NegativeInfinity;
            }
            else if (y > 1)
            {
                x = 1 - (1 / y);
                coeff = -1;
            }
            for (int i = 1; i < range; i++)
            {
                sum -= (Math.Pow(x, i) / i);
                if (sum == sumControl)
                {
                    return coeff * sum;
                }
                sumControl = sum;
            }
            return 0;
        }
        public static double LogBase(double y, double b=10)
        {
            double result = Ln(y) / Ln(b);
            if (Math.Floor(result + 0.0000001) > Math.Floor(result))
            {
                result = Math.Ceiling(result);
            }
            return result;
        }
    }
}