using System;

namespace ClassMethodTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 3, y = 4;
            decimal v = 1.3m, w = 1.7m;
            /* 2. In the Main() method of the console app, instantiate
             * the class and call the one method, passing in an integer,
             * such as 12. Then display the result to the screen.
             */
            MathClass add = new MathClass();
            Console.WriteLine(MathClass.Formula(x, y));
            /*4. In the Main() method of the console app, instantiate 
             * the class and call the second method, passing in a decimal. 
             * Display the result to the screen.
             */ 
            Console.WriteLine(MathClass.Formula(v,w));
            /*6. In the Main() method of the console app, instantiate the 
             * class and call the third method, passing in a string that 
             * equates to an integer. Display the result to the screen.
             */ 
            string z = "10";
            int parsedZ;
            if (int.TryParse(z, out parsedZ))
            {
                Console.WriteLine(MathClass.Formula(parsedZ, x));
            }
                       
        Console.ReadLine();

        }

    }
}
