using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncomeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hours1, Rate1, Hours2, Rate2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1\nHourly Rate?");

            int.TryParse(Console.ReadLine(), out Rate1);

            Console.WriteLine("Hours worked per week?");
            int.TryParse(Console.ReadLine(), out Hours1);

            Console.WriteLine("Person 2\nHourly Rate?");

            int.TryParse(Console.ReadLine(), out Rate2);

            Console.WriteLine("Hours worked per week?");
            int.TryParse(Console.ReadLine(), out Hours2);

            Console.WriteLine("Weekly salary of Person 1:\n" + (Rate1 * Hours1).ToString());

            Console.WriteLine("Weekly salary of Person 2:\n" + (Rate2 * Hours2).ToString());

            Console.WriteLine("Does Person 1 make more than Person 2?");

            bool result = ((Rate1 * Hours1) > (Rate2 * Hours2)) ? true : false;

            Console.WriteLine(result.ToString());
        }
    }
}
