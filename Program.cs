using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            DateTime time = DateTime.Now;             // Use current time.
            string format = "MMM ddd d HH:mm yyyy";   // Use this format.
            Console.WriteLine(time.ToString(format)); // Write to console.
            Console.WriteLine("");
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Console.WriteLine("Remember, we’re “accounting” on you!");
            Console.Read();
        }
    }
}
