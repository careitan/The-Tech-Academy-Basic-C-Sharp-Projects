using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParamsUserInput
{
    public class Something
    {
        public static int DoSomething(int Value1, int Value2 = 3)
        {
            return (Value1 + 200) / Value2;
        }

    }
}
