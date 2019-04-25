using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number MyNum = new Number();

            MyNum.Amount = 3.14159m;

            Console.WriteLine("Here is a number from a struct {0}", MyNum.Amount.ToString());
        }
    }
}
