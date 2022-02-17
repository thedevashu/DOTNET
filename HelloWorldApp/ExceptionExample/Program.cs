using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Employee e1 = new Employee();
            Employee e2 = new Employee(12, "Namu Kaka", 980000);

            try
            {
                Console.WriteLine(DivideNum(12, 045));
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static int DivideNum(int a,int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("cannot divide by zero");
            }
            return a / b;
        }
    }

    //1) WAP for dividing number   hanlde the exceptions using try and catch and finally (Note: take hard coded values)

    //2)create class Employee ,Parameterized constructor and parameter less constructor and call them

    //3) diff bet class and struct
}
