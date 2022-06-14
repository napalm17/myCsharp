using System;
namespace control_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            // WhileLoop();
            ForLoop();
        }
        static void ForLoop()
        {
            for (int i = 10; i >= 0; i--)
            {
                for (int j = i; j < 10; j++)
                {
                    if (j == 7)
                    {
                        System.Console.Write("* ");
                        continue;
                    }
                    System.Console.Write(j + " ");
                }
                System.Console.WriteLine();
            }
        }
        static void WhileLoop()
        {
            int range = 50;
            int i = 0;
            int l = range;
            while (i < range)
            {
                if(i % 2 != 0)
                {
                    for (int k = 0; k < l; k++)
                    {
                        System.Console.Write(" ");
                        
                    }
                    int j = 0;
                    while (j < i)
                    {
                        
                        System.Console.Write("o");
                        j++;
                    }
                    System.Console.WriteLine();
                    l--;
                }   
                i++;
                
            }
            System.Console.WriteLine();
            // int j = 0;
            // do
            // {
            //     System.Console.WriteLine(j);
            //     j++;
            // }
            // while (Convert.ToString(j).Length < 3);
        }
        static void SwitchStatements()
        {
            string name = "iron man";
            switch(name)
            {
                case "iron man":
                    System.Console.WriteLine("marvel");
                    break;
                case "batman":
                    System.Console.WriteLine("DC");
                    break;
                default:
                    System.Console.WriteLine("none");
                    break;
            }
        }
        static void IfStatements()
        {
            int x = 5;
            int y = 12;
            if (x == 5 && y % x == 0) Console.WriteLine("ok"); //single line if
            else if (x == 5 || y % x != 0)
            {
                Console.WriteLine("notok");
            }
        }
    }
}
