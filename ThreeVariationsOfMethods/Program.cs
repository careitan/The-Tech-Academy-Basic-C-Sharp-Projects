using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeVariationsOfMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyNum = 42;
            decimal MyDec = 3.14m;
            string ANum = "12";
            string BadNum = "Hello World";

            Console.WriteLine("Results for INT: {0}", Something.DoSomething(MyNum));
            Console.WriteLine("Results for DEC: {0}", Something.DoSomething(MyDec));
            Console.WriteLine("Results for String-NUM: {0}", Something.DoSomething(ANum));
            Console.WriteLine("Results for String-Word: {0}", Something.DoSomething(BadNum));

        }
    }
}
