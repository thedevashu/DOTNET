using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    public delegate void Passing(int marks);
    //public delegate void Failing(int marks);
    class School
    {
        public static void Failing(int marks)
        {
            Console.WriteLine("You Failed: " +marks);
        }
        public static void Passing(int marks)
        {
            if (marks > 40) Console.WriteLine("You Passed: " + marks);
        }
    }
}
