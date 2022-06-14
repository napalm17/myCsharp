using System;
using System.Linq;
namespace mathemathics
{
    public class NumberPi
    {
        public static double AreaMethod(double total=10000, int diameter=10000)
        {
            double insideCircle = 0;
            int radius = diameter / 2;
            var rand = new Random();
            for (int i = 0; i < total; i++)
            {    
                int x = rand.Next(diameter);
                int y = rand.Next(diameter);
                double distance = Pythagoras.PythagorasMethod(x - radius, y - radius);
                if (distance <= radius)
                {
                    insideCircle++;
                }
            }
            return 4 * (insideCircle / total);
        }
        public static double EulersMethod(double scale=10000)
        {
            double sum = 0;
            for (int i = 1; i < scale; i++)
            {
                sum += (1 / Math.Pow(i, 2));
            }
            return Math.Sqrt(6 * sum);
        }
        public static double LeibnizMethod(double scale=10000)
        {
            double sum = 0;
            for (int i = 0; i < scale; i++)
            {
                sum += (Math.Pow(-1, i) / (2*i+1));
            }
            return 4 * sum;
        }
    }
}