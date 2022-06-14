using System;

namespace string_reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ReverseString("napoleon");
            System.Console.WriteLine(reversed);
        }
        static string ReverseString(string raw)
        {
            string reversed = null;
            for (int i = raw.Length - 1; i >= 0; i--)
            {
                reversed += raw[i];
            }
            return reversed;
        }
    }
}
