using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //delegate int MyMathsFun(int a, int b);
    class Program
    {
        #region copid to MathController
        //public static int add(int a, int b) { return a + b; }
        //public static int sub(int a, int b) { return a - b; }
        // public static int mul(int a, int b) { return a * b; }
        //public static int div(int a, int b) { return a / b; }
        #endregion
        static void Main(string[] args)
        {
            MyMathsFun fun = new MyMathsFun(MathController.sub);
            int ans=fun(12, 34);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
