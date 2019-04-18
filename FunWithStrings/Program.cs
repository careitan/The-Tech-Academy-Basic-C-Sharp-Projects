using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Console.WriteLine("Here are three little strkngs:");
            Console.Write(Value1 + "; " + Value2 + "; ");
            Console.WriteLine(Value3 + "; ");

            Console.WriteLine("For my first trick I will concatinate them together: " + ConCat);
            Console.WriteLine("For my next trick I will convert something to uppercase: " + ConCat.ToUpper());



        }
    }
}
