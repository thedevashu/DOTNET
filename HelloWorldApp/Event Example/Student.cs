using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    public class Student
    {
        public event Passing op;
        public event Passing bot; 
        public string name { get; set; }
        public int marks;

        public void setMarks(int m)
        {
            if (m > 40) op(m);
            else bot(m);
        }
    }
}
