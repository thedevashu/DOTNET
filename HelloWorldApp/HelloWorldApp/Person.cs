using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApp
{
    class Person
    {
        //class member
        private string _firstname;

        //geter and seter
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

    }
}
