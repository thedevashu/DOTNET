using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
    public delegate void  AgeMsg();
    public class AgeController
    {
        public static void ValidAge()
        {
            Console.WriteLine("18+");
        }
    }
}
