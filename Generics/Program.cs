using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> MyEmp1 = new Employee<string>();
            Employee<int> MyEmp2 = new Employee<int>();

            MyEmp1.Things = new List<string>() { "Coffee Mug", "Sliderule", "Red Swingline Stapler" };
            MyEmp2.Things = new List<int>() { 2, 5, 7, 9 };

            foreach (string thing in MyEmp1.Things)
            {
                Console.WriteLine("MyEmp1 thing is: {0}", thing);
            }
            Console.WriteLine();

            foreach (int thing in MyEmp2.Things)
            {
                Console.WriteLine("MyEmp2 thing is: {0}", thing.ToString());
            }

        }
    }
}
