using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEmployee
{
    public class Employee:Person, IQuittable
    {
        int ID;

        public void Quit()
        {
            Console.WriteLine("{0} {1} says, 'I QUIT!'",this.FirstName,this.LastName);
        }
    }
}
