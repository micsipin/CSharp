using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReportDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("Please enter your name.");
            string yourName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(yourName + ", What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("What page number are you on?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Do you need anything? Please answer True of False");
            Boolean needAnything = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Were there any positive experiecnes you'd like to share? Please give specifics.");
            string experieces = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("How many hours did you study today?");
            byte hoursNum = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Thank you, " + yourName + " for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("");
            Console.WriteLine("Logged at:");
            DateTime time = DateTime.Now;
            string format = "MMM ddd d HH:mm yyyy";
            Console.WriteLine(time.ToString(format));
            Console.ReadLine();

        }
    }
}
