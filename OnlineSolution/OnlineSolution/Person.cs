using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSolution
{
    class Person
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _contactnumber;
        static int _count=0;
        public Person(string fn,string ln,string email,string cn){
            _firstname = fn;
            _lastname = ln;
            _email = email;
            _contactnumber = cn;
            _count++;

        }
        override
        public string ToString()
        {
            return "Emp no:"+_count+" Name:" + _firstname + " " + _lastname + " Email:" + _email + " Contact:" + _contactnumber;
        }
        public string ContactNumber
        {
            get
            {
                return _contactnumber;
            }
            set
            {
                _contactnumber = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

    }
}
