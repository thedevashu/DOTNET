using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.FirstName = "oyoy";
            Console.WriteLine(p.FirstName);
        }
    }
}
