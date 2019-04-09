using System;

namespace InsuranceQual
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age =0;
            bool HasDUI = false;
            int NumTickets = 0;

            Console.WriteLine("What is your age?");
            int.TryParse(Console.ReadLine(), out Age);

            Console.WriteLine("Have you ever had a DUI?");
            bool.TryParse(Console.ReadLine().ToLower(), out HasDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            int.TryParse(Console.ReadLine(), out NumTickets);

            Console.WriteLine("Qualified?");
            bool result = ((Age > 15) && (!HasDUI) && (NumTickets <= 3)) ? true : false;
            Console.WriteLine(result);

        }
    }
}
