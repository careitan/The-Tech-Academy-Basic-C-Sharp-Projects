using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyNum = 0;

            GetNumber:
            Console.WriteLine("Please give me an imput number to work with?");
            string Input = Console.ReadLine();

            bool result = int.TryParse(Input, out MyNum);

            if (!result)
            {
                Console.WriteLine("No seriously, I need a number.");
                goto GetNumber;
            }

            Console.WriteLine("\nYour number times 50 is: " + (MyNum * 50).ToString());

            Console.WriteLine("\nYour number is just 25 below:  " + (MyNum + int.Parse("25")).ToString());

            Console.WriteLine("\nHere is what we get when we divide your number by 12.5: " + ((float)MyNum / float.Parse("12.5")).ToString());

            bool IsGreaterThan = (MyNum > 50) ? true : false;

            Console.WriteLine("\nIs your number greater than 50? " + IsGreaterThan.ToString());

            Console.WriteLine("\nAfter dividing your number by 7 we have w remainder of: " + (MyNum % 7).ToString());
        }
    }
}
