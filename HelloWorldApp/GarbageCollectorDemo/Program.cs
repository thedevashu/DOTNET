using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    public class Person
    {
        public string name;
        public string loc;
        public override string ToString()
        {
            return name + " " + loc;

        }
        public Person()
        {
            Console.WriteLine("Object created");
        }
        ~Person()
        {
            Console.WriteLine("Object data cleaned");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
        }
    }
}
