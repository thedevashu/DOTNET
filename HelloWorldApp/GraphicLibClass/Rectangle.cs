using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibClass
{
    public class Rectangle:Shape
    {
        public Line Length { get; set; }
        public Line Height { get; set; }

        public Rectangle(Line l,Line h) 
        {
            Length = l;
            Height = h;
        }
        public override int Draw()
        {
            int area = Length.Draw() * Height.Draw();
            return area;
        }

        public override string ToString()
        {
            return "Length: " + Length.Draw() + "\nHeight: " + Height.Draw();
        }
    }
}
