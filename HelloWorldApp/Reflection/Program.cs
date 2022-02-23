using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //An assembly is a collection of types and resources that are built
            //to work together and form a logical unit of functionality. 
            Assembly asm = Assembly.GetExecutingAssembly();
            //we get Assembly object of current 
            Console.WriteLine(asm.Location);
            string path = @"Z:\IET_DAC\.NET_Code\HelloWorldApp\GraphicLibClass\bin\Debug\GraphicLibClass.dll";

            Assembly asmlib = Assembly.LoadFile(path);
            Type[] allType = asmlib.GetTypes();//GetTypes return array of all types

            foreach(Type t in allType) {
                MethodInfo[] minfo = t.GetMethods();
                foreach(MethodInfo m in minfo)
                {
                    Console.WriteLine(m.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
