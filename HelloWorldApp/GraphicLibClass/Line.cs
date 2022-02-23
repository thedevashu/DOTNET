using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibClass
{
    public class Line:Shape,IPrintable
    {
        Point StartPoint { get; set; }
        Point EndPoint { get; set; }

        public Line(Point s,Point e)
        {
            StartPoint = s;
            EndPoint = e;
        }
        
        public override int Draw()
        {
            return (int)(Math.Sqrt((Math.Pow(StartPoint.X - EndPoint.X, 2)) + (Math.Pow(StartPoint.Y - EndPoint.Y, 2))));
        }
        public override string ToString()
        {
             
            return "Start: "+StartPoint+" End:"+EndPoint ;
        }

        public void printOnPaper()
        {
            Console.WriteLine("Printing On A4 Paper: " + this.ToString());
        }

        public void PrintOnTV()
        {
            Console.WriteLine("Printing On Tv Screen: " + this.ToString());
        }

        public void PrintOnAir()
        {
            Console.WriteLine("Hologram In Air of: " + this.ToString());
        }
    }
}
