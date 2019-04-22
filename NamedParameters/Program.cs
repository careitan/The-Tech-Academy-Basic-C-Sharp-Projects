using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Something.DoSomething(1, 2);
            Something.DoSomething(Value2: 6, Value1: 3);
        }
    }
}
