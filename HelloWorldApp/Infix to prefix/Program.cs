using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_to_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "A*(B+C)/D";
            Stack<char> stk = new Stack<char>();
            string op = "";
            foreach(char c in ip)
            {
                Console.WriteLine(c);
                if(c >= 'A' && c <= 'Z')
                {
                    stk.Push(c);
                }
                else if (c == '(')
                {
                    stk.Push(c);
                }
                else if(c == ')')
                {
                    while (stk.Peek() != '(') ;
                    {
                        op += stk.Pop();
                    }
                    stk.Pop();
                }
                else if(c =='+' || c =='-' || c == '*' || c =='/')
                {
                    
                    op += c;
                }
                if (stk.Count() > 0) ;
                //Console.WriteLine(stk.Pop());
            }
            
            Console.ReadLine();
        }
    }
}
