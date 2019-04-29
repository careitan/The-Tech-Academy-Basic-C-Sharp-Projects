using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\log.txt";

            Console.WriteLine("The Current Date and Time is: " + System.DateTime.Now);
            Console.WriteLine("Please give me a whole number: ");

            try
            {
                int MyNum = int.Parse(Console.ReadLine());

                //TimeSpan Delta = new TimeSpan(MyNum, 0, 0);
                //TimeSpan NewSpan = System.DateTime.Now.TimeOfDay.Add(Delta);
                //System.DateTime Output = new System.DateTime(NewSpan.Ticks);
                System.DateTime Output = System.DateTime.Now.AddHours(MyNum);

                Console.WriteLine("In {0} hours from now it will be... {1}", MyNum,  Output.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
