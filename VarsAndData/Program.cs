using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            string CourseName = string.Empty;
            string PositiveExperience = string.Empty;
            string Feedback = string.Empty;

            int PageNumber = 0;

            decimal HoursOfStudy = 0.0m;

            bool NeedHelp = false;

            // Start displaying Content
            Console.WriteLine("The Tech Academy\n");
            Console.WriteLine("Student Daily Report\n");

            Console.WriteLine("What course are you on?");
            CourseName = Console.ReadLine();

            GetPageNumber:
            Console.WriteLine("What Page Number?");
            string Response = Console.ReadLine();
            bool success = int.TryParse(Response, out PageNumber);

            if (!success)
            {
                Console.WriteLine("Uhh... Run that by me again.\n");
                goto GetPageNumber;
            }

            GetHelpNeeded:
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            Response = Console.ReadLine();

            if (Response.ToLower()=="true" || Response.ToLower() == "false")
            {
                NeedHelp = (Response.ToLower() == "true") ? true : false;
            }
            else
            {
                Console.WriteLine("Uhh... Run that by me again.\n");
                goto GetHelpNeeded;
            }

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            PositiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Feedback = Console.ReadLine();

            GetHoursOfStudy:
            Console.WriteLine("How many hours did you study today?");
            Response = Console.ReadLine();
            success = decimal.TryParse(Response, out HoursOfStudy);

            if (!success)
            {
                Console.WriteLine("Uhh... Run that by me again.\n");
                goto GetHoursOfStudy;
            }

            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly.  Have a great day!");
        }
    }
}
