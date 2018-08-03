using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAndMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("TYPE IN A NUMBER");
            int numO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TYPE IN ANOTHER NUMBER");
            int numT = Convert.ToInt32(Console.ReadLine());
            
            Subtract subtract = new Subtract();
            subtract.num1 = numO;
            subtract.num2 = numT;
            Console.WriteLine();
            Console.WriteLine("Subtration");
            Console.WriteLine(subtract.num1 - subtract.num2);
            Console.WriteLine();
            Console.WriteLine("Multiply");
            Multiply multiply = new Multiply();
            multiply.num1 = numO;
            multiply.num2 = numT;
            Console.WriteLine(multiply.num1 * multiply.num2);
            Console.WriteLine();
            Console.WriteLine("Add");
            Add add = new Add();
            add.num1 = numO;
            add.num2 = numT;
            Console.WriteLine(add.num1 + add.num2);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
