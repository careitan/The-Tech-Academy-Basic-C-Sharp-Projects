using System;


namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height, Length, Width, Weight;

            Console.WriteLine("Welcome to Package Express.  Please follow teh instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int.TryParse(Console.ReadLine(), out Weight);

            if (Weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.  Have a good day.");
                return;
            }

            Console.WriteLine("Please enter the package width:");
            int.TryParse(Console.ReadLine(), out Width);

            Console.WriteLine("Please enter the package height:");
            int.TryParse(Console.ReadLine(), out Height);

            Console.WriteLine("Please enter the package length:");
            int.TryParse(Console.ReadLine(), out Length);

            if ((Width + Height + Length) > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.  Have a good day.");
                return;
            }

            decimal Cost;
            Cost = decimal.Parse((Width + Height + Length).ToString());
            Cost *= decimal.Parse(Weight.ToString());
            Cost /= decimal.Parse("100");

            Console.WriteLine("Your estimated total for shipping this package is: " + string.Format("{0:C}", Cost));
            Console.WriteLine("Thank you.");
        }
    }
}
