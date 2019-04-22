using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Something
    {
        public static void DoSomething(int Value)
        {
            Console.WriteLine("The output result is: {0}", Value / 2);
        }

        public static void DoSomething(int Value, out int Output)
        {
            Output = Value / 2;
        }
    }
}
