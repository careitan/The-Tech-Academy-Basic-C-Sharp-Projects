using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeVariationsOfMethods
{
    public class Something
    {
        public static int DoSomething(int Value)
        {
            return Value * 6;
        }

        public static int DoSomething(decimal Value)
        {
            return (int)Value + 6;
        }

        public static int DoSomething(string Value)
        {
            int result = int.MinValue;

            if(int.TryParse(Value, out result))
            {
                return result * result;
            }

            return result;
        }
    }
}
