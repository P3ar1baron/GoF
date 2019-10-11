using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Attendee
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }

        public Attendee(string firstName,string lastName)
        {
            FistName = firstName;
            LastName = lastName;
        }

    }
}
