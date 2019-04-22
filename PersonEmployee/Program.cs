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
            Employee MyEmp = new Employee() { FirstName = "Allan", LastName = "Reitan" };

            MyEmp.SayName();
        }
    }
}
