using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib2
{
    public class Employee:Person
    {
        public string Department { get; set; }
        public string Location { get; set; }
        public int BasicSalar { get; set; }
        public int dailyallowance { get; set; }

        public Employee(string dep,string loc,int bsal,int da,string fn,string ln,string e,string c) : base(fn, ln, e, c)
        {
            Department = dep;
            Location = loc;
            BasicSalar = bsal;
            dailyallowance = da;
        }

        public virtual int Computepay()//write virtual so that child class can override Computepay method
        {
            return BasicSalar + (dailyallowance * 30);
        }
        public override string ToString()
        {
            return base.ToString() + " " + Department + " " + Location + " " + BasicSalar + " " + dailyallowance;
        }
    }
}
