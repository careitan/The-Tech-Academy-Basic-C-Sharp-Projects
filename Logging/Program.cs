using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = System.Environment.CurrentDirectory + @"\log.txt";

            int MyNum = int.MinValue;

            Console.WriteLine("Please give me a number: ");
            if (int.TryParse(Console.ReadLine(), out MyNum))
            {
                File.WriteAllText(filePath, MyNum.ToString());
            }
            else
            {
                throw new NotFiniteNumberException();
            }

            Console.WriteLine("... and after saving that number to a file here is what we have in the file:");
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}
