using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMethodType
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Type in a number.");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                MathOp addDivide = new MathOp();
                addDivide.Num1 = Num1;
                int calculateInt = addDivide.AddDivide(Num1);
                Console.WriteLine("(" + Num1 + "+" + Num1 + ")/" + Num1 + " = " + calculateInt);
                Console.WriteLine();

                Console.WriteLine("Type in a decimal number.");
                decimal Num2 = Convert.ToDecimal(Console.ReadLine());
                MathOp divideAdd = new MathOp();
                divideAdd.Num2 = Num2;
                decimal calculateDec = divideAdd.DivideAdd(Num2);
                Console.WriteLine("(" + Num2 + "/" + Num2 + ")+" + Num2 + " = " + calculateDec);
                Console.ReadLine();

                Console.WriteLine("Type in a number.");
                string Num3 = Console.ReadLine();
                MathOp MultiAddDivide = new MathOp();
                MultiAddDivide.Num3 = Convert.ToInt32(Num3);
                decimal calculateString = MultiAddDivide.MultiAddDivide(Convert.ToInt32(Num3));
                Console.WriteLine("(" + Num3 + "*" + Num3 + ")+" + Num3 + " / " + Num3 + " = " + calculateString);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
