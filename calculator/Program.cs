using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Enter an operation: ");
            string input = Console.ReadLine();
            double result = Calculate(input);
            System.Console.WriteLine($"{input} = {result}");
        }
        static double Calculate(string input)
        {
            try
            {
                string[] arr = input.Split(" ");
                double num1 = Convert.ToDouble(arr[0]);
                double num2 = Convert.ToDouble(arr[2]);
                char op = Convert.ToChar(arr[1]);
                
                switch(op)
                {
                    case '+':
                        return num1 + num2;
                    case '-':
                        return num1 - num2;
                    case '*':
                        return num1 * num2;
                    case '/':
                        return num1 / num2;
                    default:
                        return 0;
                }
            }
            catch(Exception)
            {
                System.Console.WriteLine($"Invalid operation: {input}");
                return 0;
            }
        }
    }
}
