using System;

namespace mathemathics
{
    public class Pythagoras
    {
        public static double PythagorasMethod(double leg1, double leg2)
        {
            return Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2)); 
        }
    }
}