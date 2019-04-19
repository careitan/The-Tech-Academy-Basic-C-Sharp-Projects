using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BunchOfStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyListBundle = new ArrayList();

            string[] Output;

            string result = string.Empty;

            while (result != @"[Done]")
            {
                Console.Write("Please Give me a String: ");
                result = Console.ReadLine();
                MyListBundle.Add(result);
            }

            Output = (string[])MyListBundle.ToArray(typeof(string));

            result = string.Join(" ", Output);

            Console.WriteLine("\nHere is what you sent me...");
            for (int i = 0; i < Output.Length; i++)
            {
                Console.WriteLine(Output[i]);
            }

            // ----- BEGIN Waste of Time ------
            // Question #2 & #3 on the drill.
            // Here is the part where I created an infinite loop and then fi ed it by deleting it.
            // ----- FINISH Waste of Time -----

            // ----- Question #4 -----
            // ----- Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            // ----- See loop above.

            // ----- Question #5 -----
            // ----- Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            // ----- See loop above.

            Console.WriteLine("\nHere is half of what you sent me...");
            for (int i = 0; i <= (Output.Length / 2); i++)
            {
                Console.WriteLine(Output[i]);
            }

            // Making a list and checking it twice.

            List<string> BunchOfWords = new List<string>
            {
                "John"
                ,"Paul"
                ,"George"
                ,"Ringo"
                ,"Gandalf"
                ,"Frodo"
                ,"Sam"
                ,"Merry"
                ,"Pippin"
            };

            Console.Write("\nGive me a string to search a list of Names for: ");
            result = Console.ReadLine();

            if (BunchOfWords.Contains(result))
            {
                Console.WriteLine("I found your word in the list at Index of: " + BunchOfWords.IndexOf(result).ToString());
            }
            else
            {
                Console.WriteLine("I am sorry, I am afraid I can't find that on the list.");
            }

            // Ok now hte same trick again but with a couple of double words in the list
            BunchOfWords = new List<string>
            {
                "John"
                ,"Paul"
                ,"George"
                ,"Ringo"
                ,"Gandalf"
                ,"Frodo"
                ,"Sam"
                ,"Merry"
                ,"Pippin"
                ,"Wyatt"
                ,"Ringo"
                ,"Virgil"
                ,"Morgan"
                ,"James"
            };

            Console.Write("\nGive me a string to search a list of Names for: ");
            result = Console.ReadLine();
            if (BunchOfWords.Contains(result))
            {
                int Position = BunchOfWords.IndexOf(result);
                Console.Write("I found your word in the list at Index(indices) of: " + Position.ToString());
                while (Position != BunchOfWords.LastIndexOf(result))
                {
                    Position = BunchOfWords.IndexOf(result, Position+1);
                    Console.Write(" " + Position.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("I am sorry, I am afraid I can't find that on the list.\n");
            }

            // Ok once more with another layer if crazy search.
            BunchOfWords = new List<string>
            {
                "John"
                ,"Paul"
                ,"George"
                ,"Wyatt"
                ,"Ringo"
                ,"Gandalf"
                ,"Frodo"
                ,"Sam"
                ,"Merry"
                ,"Pippin"
                ,"Wyatt"
                ,"Ringo"
                ,"Virgil"
                ,"Morgan"
                ,"James"
            };


            Console.WriteLine();
            List<string> AlreadyFound = new List<string> { };
            foreach (string Word in BunchOfWords)
            {
                Console.Write("\nItem in List: " + Word);

                if (AlreadyFound.Contains(Word))
                {
                    Console.Write("; Already in List");
                }
                else
                {
                    Console.Write("; NOT Already in List");
                    AlreadyFound.Add(Word);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
