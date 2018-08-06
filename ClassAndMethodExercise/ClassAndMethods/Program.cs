using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number.");
            int numO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in another number.");
            int numT = Convert.ToInt32(Console.ReadLine());

            Formulas addition = new Formulas();
            Formulas subtraction = new Formulas();
            Formulas multiplication = new Formulas();
            addition.num1 = numO;
            addition.num2 = numT;
            Console.WriteLine("Addition total");
            Console.WriteLine(addition.num1 + addition.num2);
            subtraction.num1 = numO;
            subtraction.num2 = numT;
            Console.WriteLine("Subtraction total");
            Console.WriteLine(subtraction.num1 - subtraction.num2);
            multiplication.num1 = numO;
            multiplication.num2 = numT;
            Console.WriteLine("Multiplication total");
            Console.WriteLine(multiplication.num1 * multiplication.num2);
         
            Console.ReadLine();
            

        }
    }
}
