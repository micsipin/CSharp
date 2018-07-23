using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleDemo
{
    class Program
    {
        static void Main()
        {
          
            //multiply user input by 50
            int firstNum, multiplier = 50, firstTotal = 0;
            Console.WriteLine("Please input any number.");
            firstNum = int.Parse(Console.ReadLine());
            firstTotal = firstNum * multiplier;
            Console.WriteLine("Your number multipled by 50 is " + firstTotal + ".");
            Console.ReadLine();
            Console.WriteLine();

            //add 25 to user input
            int secondNum, addends = 25, secondTotal = 0;
            Console.WriteLine("Please input any number.");
            secondNum = int.Parse(Console.ReadLine());
            secondTotal = secondNum + addends;
            Console.WriteLine(secondTotal + " is the sum when 25 is added to your number.");
            Console.ReadLine();
            Console.WriteLine();

            // divide user input by 12.5
            decimal thirdNum, divisor = 12.5m, thirdTotal = 0;
            Console.WriteLine("Please input any number.");
            thirdNum = decimal.Parse(Console.ReadLine());
            thirdTotal = thirdNum / divisor;
            Console.WriteLine(thirdTotal + " is the quotient when dividing your number with a divisor of 12.5.");
            Console.ReadLine();
            Console.WriteLine();

            //check user input if greater than 50
            int forthNum, compareNum = 50;
            Console.WriteLine("Please input any number.");
            forthNum = Convert.ToInt32(Console.ReadLine());
            compareNum = 50;
            bool Check = (forthNum > compareNum);
            if (forthNum > compareNum)
                Console.WriteLine("Your number is greater than 50.");
            else if (forthNum < compareNum)
                Console.WriteLine("Your number is less than 50.");
            else
                Console.WriteLine("Your number is equal to 50.");
            Console.ReadLine();
            Console.WriteLine();

            //get modulus from user input by using divisor of 7
            decimal fifthNum, divisor2 = 7, fifthTotal = 0;
            Console.WriteLine("Please input any number.");
            fifthNum = decimal.Parse(Console.ReadLine());
            fifthTotal = fifthNum % divisor2;
            Console.WriteLine(fifthTotal + " is the modulus when dividing your number with a divisor of 7.");
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}
