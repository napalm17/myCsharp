using System;

namespace OOP
{
    public class Slave: User
    {
        string _firstName;
        string _lastName;
        public Slave()
        {
            System.Console.WriteLine("created a user!");
        }

        public Slave(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

        }

        public override void Method(int times = 1)
        {
            System.Console.WriteLine($"Hello Slave {_firstName}");
            // same thing // base.Method(times);
        }
    }
}