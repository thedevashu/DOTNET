using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib2
{
    public class Person
    {

        public string FName { set; get; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string  ContactNumber { get; set; }

        public Person(string f,string l,string e,string c)
        {
            FName = f;
            LName = l;
            Email = e;
            ContactNumber = c;
        }

        public override string ToString()
        {
            return FName + " " + LName + " " + Email + " " + ContactNumber;
        }




    }
}
