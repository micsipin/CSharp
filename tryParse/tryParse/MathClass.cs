using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodTypes
{
    /*1.1. Create a class. In that class, create a method to it
     * and that will take in an integer,do a math operation 
     * then return the answer as an integer .
     */
    class MathClass
    {
        public static int Formula(int num1, int num2)
        {
            return num1 + num2;
        }
        /*3. Add a second method to the class, with the same name,
         * that will take in a decimal, do a different math operation 
         * to it and then return the answer as an integer.
         */
        public static decimal Formula(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        /*5. Add a third method to the class, with the same name, 
         * that will take in a string, convert it to an integer if 
         * possible, do a different math operation to it and then 
         * return the answer as an integer.
         */
        //public static string Formula(string num1, string num2)
        //{
        //    if (Int32.TryParse(num1, out int intNum1) && Int32.TryParse(num2, out int intNum2)) ;
        //    {
        //        return (num1 + num2).ToString();
        //    }
        //    else
        //    {

        //    }
        //}

        public static string Formula(string num1, string num2)
        {
            
            if (Int32.TryParse(num1, out int intNum1) && Int32.TryParse(num2, out int intNum2))
            {
                return (num1 + num2).ToString();
            }
            else
            {
                return "This string can't convert to an int.";
             
            }
        }

    }

}
