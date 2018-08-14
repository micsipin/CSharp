using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethodOverloadStatic
{
    /*6. Declare a class to be static.
     */
    static class Divider
    {
        public static void Main()
        {
            /*2. In the Main() method, instantiate that class
             */

            DivideClass div = new DivideClass();
           

            /*3. Have the user enter a number. Call the method 
             * on that number. Display the output to the screen. 
             * It should be the entered number, divided by two.
             */
            Console.WriteLine("number?");
            int num1 = Int32.Parse(Console.ReadLine());

            //ref int total
            div.Divide(num1, out int total);
            total =  num1 / 2 ;
            Console.WriteLine(total);
            Console.ReadLine();
            /*5. Overload a method.
             */
            Add(3, 4);
                       
        }
        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN, int TN, int FourthNum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }


    }
}
    
        
   


