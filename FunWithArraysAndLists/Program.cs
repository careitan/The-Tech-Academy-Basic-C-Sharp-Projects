using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyStrings =
            {
                "Hello World"
                ,"What's up, Doc!"
                ,"I'll be back"
                ,"Yippee-Ki-Yi-Yah..."
                ,"Let's see what this button does..."
                ,"Now why did you go and press that one?"
            };

            int[] MyInts = { 1, 20, 42, 100, 256, 500, 1000, 2048, 6000, 10000 };

            List<string> MyList = new List<string>();
            MyList.Add("Hello World");
            MyList.Add("What's up, Doc!");
            MyList.Add("I'll be back");
            MyList.Add("Yippee-Ki-Yi-Yah...");
            MyList.Add("Let's see what this button does...");
            MyList.Add("Now why did you go and press that one?");
            MyList.Add("Well look what we have here.");

            int UserIndex = MyStrings.Length;

            while (!IsValidIndex(UserIndex, MyStrings.Length))
            {
                Console.WriteLine("\nPlease give me an Index number from 0 to " + (MyStrings.Length - 1).ToString() + ":");
                string response = string.Empty;
                response = Console.ReadLine();
                int.TryParse(response, out UserIndex);
            }

            Console.WriteLine("\nYour fortune cookie response is: " + MyStrings[UserIndex]);

            UserIndex = MyInts.Length;
            while (!IsValidIndex(UserIndex, MyInts.Length))
            {
                Console.WriteLine("\nPlease give me an Index number from 0 to " + (MyInts.Length - 1).ToString() + ":");
                string response = string.Empty;
                response = Console.ReadLine();
                int.TryParse(response, out UserIndex);
            }

            Console.WriteLine("\nYour Lucky Integer is: " + MyInts[UserIndex].ToString());

            UserIndex = MyList.Count;
            while (!IsValidIndex(UserIndex, MyList.Count))
            {
                Console.WriteLine("\nPlease give me an Index number from 0 to " + (MyList.Count- 1).ToString() + ":");
                string response = string.Empty;
                response = Console.ReadLine();
                int.TryParse(response, out UserIndex);
            }

            Console.WriteLine("\nYour fortune cookie List<string> response is: " + MyList[UserIndex]);

        }

        public static bool IsValidIndex(int Test, int Max)
        {
            return (Math.Abs(Test) < Max);
        }
    }
}
