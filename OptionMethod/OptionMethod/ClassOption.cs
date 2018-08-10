using System;
using System.Collections.Generic;
using System.Text;

namespace OptionMethod
{
    public class ClassOption
    {
        /*1. Create a class. In that class, create a method that
         * takes two integers as parameters. Make one of them optional.
         * Have the method do a math operation and return a integer result.
         */ 
        public static int Option (int num1, int num2 )
        {
            int results = num1 * Convert.ToInt32(num2);
            return results;
        }
        
    }
}
