using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Something MyWhatever = new Something();
            string result = string.Empty;
            int MyNum = 0;
            int CatchValue = 0;

            Console.Write("Please give me a number to do something with it: ");
            int.TryParse(Console.ReadLine(), out MyNum);

            Something.DoSomething(MyNum);
            Something.DoSomething(MyNum, out CatchValue);
            Console.WriteLine("The CatchValue is: {0}", CatchValue);
        }
    }
}
