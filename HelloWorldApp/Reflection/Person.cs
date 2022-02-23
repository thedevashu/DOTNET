using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person
    {
        public string Name { get; set; }
        public string location { get; set; }
        public Person() { }
        public Person(String name,string loc) { }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
