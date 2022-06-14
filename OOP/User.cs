using System;

namespace OOP
{
    public abstract class User
    {
        
        public bool Verified { get; set; } = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set{;}
        }

        public virtual void Method(int times=1) // defaults to 1
        {
            System.Console.WriteLine($"Hello {FullName} !");
        }
    }
}