using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Person
    {
        public string name;
        public string loc;
        public override string ToString()
        {
            return name+" "+ loc;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string []a = { "asd","--asd"};
            object []o =  {"Ashu",80000,true,21.23,new Person { name="kasu",loc="lon"} };
            foreach(object ob in o)
            {
                Console.WriteLine(ob);
            }
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
