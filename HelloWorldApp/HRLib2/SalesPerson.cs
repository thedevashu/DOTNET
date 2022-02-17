using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib2
{
    public class SalesPerson:Employee
    {
        public int Target { get; set; }
        public int Achivment { get; set; }

        public SalesPerson(int tr,int ins, string dep, string loc, int bsal, int da, string fn, string ln, string e, string c) : base(dep, loc, bsal, da, fn, ln, e, c)
        {
            Target = tr;
            Achivment = ins;
        }

        public override int Computepay()
        {
            if (Target > Achivment)
                return base.Computepay() + (int)(Target * 0.09);
            else
                return base.Computepay();
        }

        public override string ToString()
        {
            return base.ToString()+" " ;
        }
    }
}
