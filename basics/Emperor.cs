using System;

namespace basics
{
    public class Emperor
    {
        string title = "ceaser";
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string FullName 
        {
            get
            {
                return LastName + FirstName;
            }
        }

        public string GetFullName()
        {
            return LastName + " " + FirstName + title;
        }

    }
}