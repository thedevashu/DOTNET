using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example
{
     
    public class Vaccinate
    {
        public event AgeMsg AChecker;
        
        public void getShot(int a)
        {
            if (a > 18)
            {
                AChecker();
            }
            else
            {
                Console.WriteLine("Not elegiable");
            }
        }
        public Vaccinate()
        {
            Console.WriteLine("Welcome Enter Your age to get vaccine||||");
        }
    }
}
