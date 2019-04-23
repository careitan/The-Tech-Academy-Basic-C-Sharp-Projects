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
            Employee MyEmp1 = new Employee() { ID = 12345 };
            Employee MyEmp2 = new Employee() { ID = 56789 };
            Employee MyEmp3 = new Employee() { ID = 12345 };

            if (MyEmp1 == MyEmp2)
            {
                Console.WriteLine("MyEmp1 == MyEmp2");
            }
            else if (MyEmp1 != MyEmp2)
            {
                Console.WriteLine("MyEmp1 != MyEmp2");
            }

            if (MyEmp1 == MyEmp3)
            {
                Console.WriteLine("MyEmp1 == MyEmp3");
            }
            else if (MyEmp1 != MyEmp3)
            {
                Console.WriteLine("MyEmp1 != MyEmp3");
            }

        }
    }
}
