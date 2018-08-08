using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
    
namespace ClassMethodType
{
    class MathOp
    {
        public int Num1  { get; set; }
        public decimal Num2 { get; set; }
        public decimal Num3 { get; set; }

        public int AddDivide(int Num1)
        {
            return (Num1 + Num1) / Num1;
        }
        public decimal  DivideAdd(decimal Num2)
        { 
            return (Num2 / Num2) + Num2;
        }
        public int MultiAddDivide(Int32 Num3)
        {
            return (Num3 * Num3) + Num3 / Num3;
        }
    }
}
