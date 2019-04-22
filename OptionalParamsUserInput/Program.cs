using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParamsUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyNum1, MyNum2, Output;
            string result = "null";

            Console.WriteLine("Please give me one or two numbers to perform Math operstions.");
            while (!int.TryParse(result, out MyNum1))
            {
                Console.Write("First Value: ");
                result = Console.ReadLine();
            }

            Console.Write("Second Value [Enter for no value]: ");
            result = Console.ReadLine();

            Output = (int.TryParse(result, out MyNum2)) ?
                Something.DoSomething(MyNum1, MyNum2) :
                Something.DoSomething(MyNum1);

            Console.WriteLine("The Output value is: {0}", Output);
        }
    }
}
