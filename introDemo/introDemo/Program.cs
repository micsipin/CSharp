using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            DateTime time = DateTime.Now;            
            string format = "MMM ddd d HH:mm yyyy";  
            Console.WriteLine(time.ToString(format)); 
            Console.WriteLine("");
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Console.WriteLine("Remember, we’re “accounting” on you!");
            Console.Read();
        }
    }
}