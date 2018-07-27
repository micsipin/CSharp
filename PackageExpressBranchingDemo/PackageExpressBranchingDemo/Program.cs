using System;

namespace PackageExpressBranchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string pkgWeight, pkgWidth, pkgLength, pkgHeight;
            int lbsLimit, dimLimit;
            bool weightScale, dimScale;
            decimal dimTotal, pkgQuote; 
            Console.WriteLine("");
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");
            Console.WriteLine("Type in package weight");
            pkgWeight = Console.ReadLine();
            lbsLimit = 50;
            if (weightScale = (Convert.ToDecimal(pkgWeight) >= lbsLimit))
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("I SAID, GOOD DAY SIR..");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Type in pack width");
            pkgWidth = Console.ReadLine();
            Console.WriteLine("Type in pack height");
            pkgHeight = Console.ReadLine();
            Console.WriteLine("Type in pack length");
            pkgLength = Console.ReadLine();
            dimLimit = 50;
            dimTotal = (Convert.ToDecimal(pkgWidth) * (Convert.ToDecimal(pkgHeight) * (Convert.ToDecimal(pkgLength))));
            if (dimScale = (dimTotal >= dimLimit))
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }
            pkgQuote = dimTotal * decimal.Parse(pkgWeight) / 100;
            Console.WriteLine("The estimated total for shipping this package is: $" + pkgQuote);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
            
        }
    }
}
