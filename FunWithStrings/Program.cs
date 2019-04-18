using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string Value1, Value2, Value3;
            string ConCat = string.Empty;
            string[] Independent = new string[]
            {
                @"We hold these truths to be self-evident,"
                ,@" that all computers are created equal,"
                ,@" that they are endowed, by their Creator,"
                ,@" with certain unalienable Rights,"
                ,@" that among these are Logic,"
                ,@" RAM,"
                ,@" and the pursuit of Load Balancing."
            };

            Value1 = @"ennie";
            Value2 = @"meenie";
            Value3 = @"miney-mo";
            ConCat = Value1 + Value2 + Value3;

            Console.WriteLine("Here are three little strings:");
            Console.Write(Value1 + "; " + Value2 + "; ");
            Console.WriteLine(Value3 + "; ");

            Console.WriteLine("\nFor my first trick I will concatinate them together: " + ConCat);
            Console.WriteLine("\nFor my next trick I will convert something to uppercase: " + ConCat.ToUpper());

            Console.WriteLine("\nOk, now lets try to build a paragraph, one phrase at a time...");
            Thread.Sleep(2000);
            Console.Write("\nReady...");
            Thread.Sleep(3000);
            Console.WriteLine("Begin!");

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            for (int i = 0; i < Independent.Length; i++)
            {
                sb.Append(Independent[i]);
                Console.WriteLine("\n" + sb.ToString());
                Thread.Sleep(5000);
            }

        }
    }
}
