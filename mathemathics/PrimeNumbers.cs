using System;
using System.Collections.Generic;

namespace mathemathics
{
    public class PrimeNumbers
    {
        public static List<int> PrimesMethod(int range=100)
        {
            List<int> primes = new List<int>();
            for(int i = 2; i < range; i++)
            {
                bool isPrime = true;
                for(int j = 2; j < i / 2 + 1; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime) {primes.Add(i);}
                else {primes.Add(0);}
            }
            return primes;
        }
    }
}
