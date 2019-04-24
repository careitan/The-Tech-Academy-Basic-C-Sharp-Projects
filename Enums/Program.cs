using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek DOW = new DaysOfWeek();

            Console.WriteLine("Please give me the current day of the week:");
            try
            {
                DOW = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
