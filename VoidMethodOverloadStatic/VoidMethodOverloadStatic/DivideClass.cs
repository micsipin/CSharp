using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethodOverloadStatic
{
    class DivideClass
    {
        /*1. Create a class. In that class, create a void method 
         * that outputs an integer. Have the method divide the 
         * data passed to it by 2.
         */
        //AND
        /*4. Create a method with output parameters.
         */
        
        public void Divide(int uNum, out int total)
        {
            int num2 = 2;
            total = uNum / num2;
        }  

    }
}
