using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimer
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime now = DateTime.Now;
            //Console.WriteLine("Time is now: ",now);
            //Console.WriteLine("Please input a number");
            //int uInput = Convert.ToInt32(Console.ReadLine());
            //DateTime uInputDate = (now.AddDays(uInput));
            //Console.WriteLine(uInputDate);
            //Console.ReadLine();


            DateTime now = DateTime.Now;
            Console.WriteLine("Time is now: ", now);
            Console.WriteLine("Please input a number");
            int uInput = Convert.ToInt32(Console.ReadLine());
            DateTime uInputHour = (now.AddHours(uInput));
            Console.WriteLine("in " + uInput + " hour(s), the time will be " + uInputHour);
            Console.ReadLine();
        }
    }
}
