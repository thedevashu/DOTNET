using System;

namespace OnlineSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p= new Person("para1","para2","para3","para4");
            p.FirstName = "Ashutosh";
            Console.WriteLine(p.FirstName);
            Console.WriteLine("Hello World!");
            Console.WriteLine(p);
            Person p1 = new Person("Raju", "Kamble","rajudon@raju.com","9876543219");
            Console.WriteLine(p1);

            Person p2 = new Person("Kaju", "Kamble", "kajudon@kaju.com", "9876543219");
            Console.WriteLine(p2);

            Person p3 = new Person("Paju", "Ramble", "Pajudon@Daju.com", "9v76543219");
            Console.WriteLine(p3);

            Person p4 = new Person("Qaju", "Zamble", "qajudon@qaju.com", "987243219");
            Console.WriteLine(p4);

            Person p5 = new Person("Xaju", "Famble", "najudon@naju.com", "9845543219");
            Console.WriteLine(p5);
        }
    }
}
