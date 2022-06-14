using System;

namespace mathemathics
{
    public class SolveQuadratic
    {
        public static double[] SolveQuadraticMethdod(double a, double b, double c)
        {
            double discriminant = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            double solution1 = (-1 * b + discriminant) / (2 * a);
            double solution2 = (-1 * b - discriminant) / (2 * a);
            return new double[] {solution1, solution2};
        }
    }
}