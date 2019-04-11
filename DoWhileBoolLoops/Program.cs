using System;

namespace DoWhileBoolLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int Control = 0;

            while (Control < 3)
            {
                Console.Write("Do... ");

                int i = 1;
                do
                {
                    if (Control < 2) { Console.Write("Be... "); } else { Console.Write("\n"); }
                    i++;
                } while (i<2);

                Control++;
            }
        }
    }
}
