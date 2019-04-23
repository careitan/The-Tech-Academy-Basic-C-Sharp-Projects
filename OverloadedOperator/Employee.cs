using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    public class Employee : Person, IQuittable
    {
        public int ID;

        public void Quit()
        {
            Console.WriteLine("{0} {1} says, 'I QUIT!'", this.FirstName, this.LastName);
        }

        public static bool operator==(Employee Employee1, Employee Employee2)
        {
            return Employee1.ID == Employee2.ID;
        }

        public static bool operator!=(Employee Employee1, Employee Employee2)
        {
            return Employee1.ID != Employee2.ID;
        }

        public override bool Equals(object o)
        {
            Employee EmpTmp = (Employee)o;
            return ID == EmpTmp.ID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
