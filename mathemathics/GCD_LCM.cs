using System;

namespace mathemathics
{
    public class GCD_LCM
    {
        
        public static int GCD(int num1, int num2)
        {
            int min = Math.Min(num1, num2);
            for (int i = min ; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    return i;
                }
            }
            return 0;

        }
        public static int LCM(int num1, int num2)
        {
            int max = Math.Max(num1, num2);
            for (int i = max; i <= num1 * num2; i++)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}