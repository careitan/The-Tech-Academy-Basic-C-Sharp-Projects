using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyInts = new List<int> { -7, 0, 4, 12, 50, 101, 210, 515 };
 
            string result = string.Empty;

            int Divisor = Int32.MinValue;

            try
            {
                Console.WriteLine("I have a list of numbers and will divide them by the number you give me:");
                result = Console.ReadLine();

                Divisor = int.Parse(result);

                for (int i = 0; i < MyInts.Count; i++)
                {
                    Console.WriteLine("For the Number [" + MyInts[i] + "], the result is: " + (MyInts[i] / Divisor));
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
