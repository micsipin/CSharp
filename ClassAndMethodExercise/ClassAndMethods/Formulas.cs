using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Formulas
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
