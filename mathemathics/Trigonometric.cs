using System;


namespace mathemathics
{
    public class Trigonometric
    {
        static double TrigMethod(double x, int range=10)
        {
            bool isOdd = Math.Floor(Math.Abs(x) / Math.PI) % 2 != 0;
            double sum = 0;
            x = x % (Math.PI);
            for (int i = 0; i < range; i++)
            {
                sum += ((Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / Factorial.Looped(2 * i));
            }
            if (isOdd)
            {
                sum *= -1;
            }
            return sum;
        }
        public static double Sin(double x)
        {
            return (x % Math.PI == 0) ? 0 : TrigMethod((Math.PI / 2) - x);
        }
        public static double Cos(double x)
        {
            return (x % (Math.PI / 2) == 0 && x % Math.PI != 0) ? 0 : TrigMethod(x);
        }
        public static double Tan(double x)
        {
            return Sin(x) / Cos(x);
        }
        static double InverseTrigMethod(double x, int range=50)
        {
            double sum = 0;
            double add = 0;
            int n = 1;
            if (x > 1)
            {
                n = -1;
                add = Math.PI / 2;
            }
            else if (x < 1)
            {
                n = -1;
                add = -1 * Math.PI / 2;
            }
            for (int i = 0; i < range; i++)
            {
                sum += (Math.Pow(-1, i) * (Math.Pow(Math.Pow(x, 2*i+1), n) / (2*i+1)));
            }
            return add + n * sum;
        }
        public static double Arcsin(double x)
        {
            return (x==0) ? 0 : InverseTrigMethod(x / Math.Sqrt(1 - Math.Pow(x, 2)));
        }
        public static double Arccos(double x)
        {
            return (x==1) ? 1 :InverseTrigMethod(Math.Sqrt(1 - Math.Pow(x, 2)) / x);
        }
        public static double Arctan(double x)
        {
            return (x==0) ? 0 : InverseTrigMethod(x);
        }
    }
}