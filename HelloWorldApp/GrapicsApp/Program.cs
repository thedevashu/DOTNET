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


            Console.ReadLine();
        }
    }
}
