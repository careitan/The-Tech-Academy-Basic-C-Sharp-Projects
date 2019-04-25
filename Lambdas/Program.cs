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
            string[] Fnames = new string[] { "Joe", "Paul", "George", "Ringo" };
            string[] Lnames = new string[] { "Jones", "Dolenz", "Turk" };

            List<Employee> Employees = new List<Employee>();
            int TmpNum = 1;

            foreach (string fname in Fnames)
            {
                foreach (string lname in Lnames)
                {
                    Employee TmpEmp = new Employee() { FirstName = fname, LastName = lname, ID = TmpNum++ };
                    Employees.Add(TmpEmp);
                }
            }

            List<Employee> TmpList = new List<Employee>();


            // Make List of Joes with For Each loop
            foreach (Employee employee in Employees)
            {
                if (employee.FirstName.Equals("Joe"))
                {
                    TmpList.Add(employee);
                    Console.WriteLine("Employee... ID: {0}; FName= {1}; LName={2}", employee.ID, employee.FirstName, employee.LastName);
                }
            }

            TmpList.Clear();
            Console.WriteLine();
            // Make List of Joes using a Lambda expression.
            TmpList = Employees.Where<Employee>(x => x.FirstName == "Joe").ToList<Employee>();

            foreach (Employee employee in TmpList)
            {
                Console.WriteLine("Employee... ID: {0}; FName= {1}; LName={2}", employee.ID, employee.FirstName, employee.LastName);
            }

            TmpList.Clear();
            Console.WriteLine();
            // Make List of ID > 5
            TmpList = Employees.Where<Employee>(x => x.ID > 5).ToList<Employee>();

            foreach (Employee employee in TmpList)
            {
                Console.WriteLine("Employee... ID: {0}; FName= {1}; LName={2}", employee.ID, employee.FirstName, employee.LastName);
            }

        }
    }
}
