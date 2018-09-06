using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you, Human?");
                int uAge = Convert.ToInt32(Console.ReadLine());
                if (uAge < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                DateTime yrBorn = DateTime.Now.AddYears(-uAge);
                Console.WriteLine("You were created in the year " + yrBorn.Year + ".");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You're too young to use this computer..unless young Jedi");
            }
            catch(System.Exception)
            {
                Console.WriteLine("Cannot Compute.. \nPlease enter a Number besides 0");
            }

            Console.ReadLine();
        }
    }
}
