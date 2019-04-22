using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    public class Something
    {
        public static void DoSomething(int Value1, int Value2)
        {
            int Void = Math.Abs(Value1);

            Console.WriteLine("Here was the second Value that you gave me: {0}", Value2);
        }

    }
}
