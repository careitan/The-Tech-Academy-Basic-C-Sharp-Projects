using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyVar = "Hello World";
            var TmpInput = string.Empty;

            Console.WriteLine("please give me some type of input to work with.");
            TmpInput = Console.ReadLine();

            Something MyObj = new Something(TmpInput);

            Console.WriteLine("The two properties of the Something Object are:");
            Console.WriteLine("Something.Word = {0}",MyObj.Word);
            Console.WriteLine("Something.Number = {0}", MyObj.Number);

            Console.ReadLine();
        }
    }
}
