using System;

namespace OptionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.In the Main() method of the console app, instantiate the class.
             */
            ClassOption Option = new ClassOption();

            /*3.Ask the user to input two numbers, one at a time.Let them know 
             * they need not enter anything for the second number.
             */
            Console.WriteLine("Please type in a number.");
            int num1 = Int32.Parse(Console.ReadLine());
            int uInput = num1;
            Console.WriteLine("**OPTIONAL** \n You may pick another number. If not, the default is chosen.");
            int numX = 40;
            string iInput = Console.ReadLine();
                      
            /*4. Call the method in the class, passing in the one or two
            * numbers entered.
            */
            if (string.IsNullOrEmpty(iInput))
            {
                Console.WriteLine(ClassOption.Option(uInput, Convert.ToInt32(numX)));
            }
            else
            {
                Console.WriteLine(ClassOption.Option(uInput, Convert.ToInt32(iInput)));
            }
            //5.Try various combinations of numbers on the code, including having no second number.

            Console.ReadLine();
        }
    }
}
