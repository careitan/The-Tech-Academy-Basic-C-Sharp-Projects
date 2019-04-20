using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            int MyNum = int.MinValue;

            try
            {
                Console.WriteLine("And now for something completely different, please give me a number:");
                result = Console.ReadLine();
                MyNum = int.Parse(result);

                Console.WriteLine("Method #1: " + LittlePigs.Straw(MyNum));
                Console.WriteLine("Method #2: " + LittlePigs.Wood(MyNum));
                Console.WriteLine("Method #3: " + LittlePigs.Brick(MyNum));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
