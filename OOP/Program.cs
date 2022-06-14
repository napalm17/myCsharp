using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProgram = new Program();
            myProgram.Method();
        }
        public void Method()
        {
            // User user1 = new User(); // can't do it because User class is abstract
            // user1.FirstName = "Calvin";
            // user1.LastName = "Candy";
            // // System.Console.WriteLine(user1.FirstName);
            // user1.Method();

            Slave user2 = new Slave("Vladimir", "Lenin");
            // user2.FirstName = "Andrew";
            // user2.LastName = "Ryan";
            // System.Console.WriteLine(user2.FullName);
            user2.Method();

        }
    }
}
