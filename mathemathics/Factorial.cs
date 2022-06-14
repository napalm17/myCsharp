using System;

namespace mathemathics
{
    public class Factorial
    {
        public static long Recursive(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else 
            {
                return number * Recursive(number - 1);
            }
        }
        public static long Looped(int number)
        {
            long total = 1; 
            for (int i = number; i > 1; i--)
            {
                total *= i;
            }
            return total;
        }
    }
}