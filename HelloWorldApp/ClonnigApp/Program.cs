using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonnigApp
{
    public class Person:ICloneable
    {
        public string Name { get; set; }
        public string location { get; set; }
        public Person() { }
        public Person(String name, string loc) { this.Name = name;this.location = loc; }
        public override string ToString()
        {
            return Name+location;
        }

        public object Clone()
        {
            
            return new Person(this.Name,this.location);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Name", "Loc");
            Console.WriteLine(p);
            Person p2 = p;
            Person p3 = p.Clone() as Person;

            Console.WriteLine(p.GetHashCode());

            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());

            if (p3 == p)
            {
                Console.WriteLine("same ref --shallo copy");

            }
            else
            {
                Console.WriteLine("not same ref");
                Console.WriteLine(p3.GetHashCode());
            }
            Console.ReadLine();
        }
    }
}
