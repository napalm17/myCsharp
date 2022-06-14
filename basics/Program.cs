using System;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = {-4};
            // References(arr);
            FromOtherClass();
        }
        static void FromOtherClass()
        {
            Emperor emperor = new Emperor();
            emperor.FirstName = "Octavian";
            emperor.LastName = "Gaius";
            Console.WriteLine(emperor.GetFullName());
            Console.WriteLine(emperor.FullName);

        }
        static void StringAndChar()
        {
            //int b = Convert.ToInt32("5");
            // char letter = (char)99;
            // int number = 'o';
            // Console.WriteLine(letter);
            // char[] chars = {'h', 'a', 'd', 'r', 'i', 'a', 'n'};
            // string hadrian = new String(chars);
            // Console.WriteLine(hadrian.Length);
            // Console.WriteLine(hadrian.CompareTo("severus"));
            // Console.WriteLine(hadrian.IndexOf("a"));
            // Console.WriteLine("   cato\n\n".Trim());
            // string[] Array = "m.a.a.d".Split('.');
            // Console.WriteLine("\"in quotes\"");
        }

        static void MathClass()
        {
            double x = 25.72737;
            Console.WriteLine(Math.Round(x, 2));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Max(1, 2));
            Console.WriteLine(Math.Min(1, 2));
            Console.WriteLine(Math.Abs(-4));
        }

        static void References(int[] a)
        {
            a[0] = 100;
        }
        static string UserInput()
        {
            string input = Console.ReadLine();
            return $"You have written {input} " + input;
        }
        static void Datatypes()
        {
            // var myVar = "ok";
            // int myInt;
            // myInt = 17;
            // string myString = "cicero";
            // char myChar = 'C';
            // float myFloat = 5.5F;
            // double myDouble = 4.2;
            // decimal myDecimal = 3.4M;
            // bool myBool = true;
            // double inf = double.PositiveInfinity;
            // Console.WriteLine(inf);
        }
    }
}
