using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age;

            try
            {
                Console.WriteLine("Please tell me what your current age is?");
                if (!uint.TryParse(Console.ReadLine(), out age)) throw new ArgumentOutOfRangeException();

                Console.WriteLine("Based on that, I am going to say that you were born in {0}", 
                    DateTime.Now.Date.AddYears((int)(-1*age)).Year);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("I don't think you gave us a practical number to work with.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ctrl + Alt + I am sorry I am afraid I just can't do that.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
