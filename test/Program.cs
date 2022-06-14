using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(a(n: 10));
        }
        static double a(int n)
        {
            double total = 0;
            for (int k = 0; k < n; k++)
            {
                total += Math.Pow((n + 2 + (1 / n)), (n - 1 - k)) * Math.Pow(n, k);
                
            }
            return (2 + (1 / n))/Math.Pow(n, n) * total;
        }
    }
}
