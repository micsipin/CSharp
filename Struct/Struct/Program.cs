using System;

namespace Struct
{
    public struct Number
    {
        public int Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number()
            {
                Amount = 80085
            };
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
