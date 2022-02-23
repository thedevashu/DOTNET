using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicLibClass;
namespace GrapicsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism

            //C# Compile Time Polymorphism

            //In c#, Compile Time Polymorphism means defining multiple methods with the same
            //name but with different parameters. Using compile-time polymorphism,
            //we can perform different tasks with the same method name by passing different
            //parameters.

            //In c#, the compile-time polymorphism can be achieved by using method
            //overloading, and it is also called early binding or static binding.

            //C# Run Time Polymorphism

            //In c#, Run Time Polymorphism means overriding a base class method in the
            //derived class by creating a similar function. This can be achieved by
            //using override & virtual keywords and the inheritance principle.
            //Using run-time polymorphism, we can override a base class method in the
            //derived class by creating a method with the same name and parameters to
            //perform a different task.
            //In c#, the run time polymorphism can be achieved by using method
            //overriding, and it is also called late binding or dynamic binding.
            #endregion
            Point p1 = new Point(0, 0);
            Point p2 = new Point(10, 0);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("------------------------------------------------------------------");
            Line l = new Line(p1, p2);
            
            Line h = new Line(new Point(5, 22), new Point(0, 5));
            Console.WriteLine(l + " Length: "+l.Draw());
            Console.WriteLine("------------------------------------------------------------------");
            Rectangle r = new Rectangle(l, h);
            Console.WriteLine("Area of rectangle: "+r.Draw());
            Console.WriteLine(r);
            Console.WriteLine("------------------------------------------------------------------");

            //There are two types of polymorphism in C#: compile time polymorphism and runtime polymorphism.
            //Compile time polymorphism is achieved by method overloading and operator overloading in C#.
            //It is also known as static binding or early binding.
            //Runtime polymorphism in achieved by method overriding which is also known as dynamic binding
            //or late binding.
            
            //Runtime polymorphism
            //Upcasting 

            Shape s = new Line(p1, p2);
            //Runtime polymorphisem we dont know which class to string will be called
            //until running the program
            Console.WriteLine(s);
            s = new Rectangle(l, h);
            Console.WriteLine(s);


            Console.ReadLine();
        }
    }
}
