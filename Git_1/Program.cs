using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_1
{
    internal class Program
    {
        static int Div(int operand1, int operand2) 
        {
            if (operand1 != 0 && operand2 != 0)
                return operand1 / operand2;
            else
                return 0;
        }
        static int Hed(int operand1, int operand2)
        {  
                return operand2 + operand2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("My first commit");
            
        }
    }
}
