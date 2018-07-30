using System;
using System.Collections.Generic;
namespace ArrayExercise
{
    class Program
    {
        static void Main()
        {
            Index1();
            Index2();
            List1();
        }

        static void Index1()
        {
            string[] strA = { "red", "yellow", "blue", "purple", "brown", "aqua", "green", "black" }; // index 0 starts at black, index 1 is green and so on
            Console.WriteLine("Choose an INDEX from 0 to 8");
            int sIndex = int.Parse(Console.ReadLine());
            if (sIndex > 8)

            {
                Console.WriteLine("invalid INDEX. Last chance. \nPlease choose INDEX 0 thru INDEX 8");
                sIndex = int.Parse(Console.ReadLine());
                Console.WriteLine(strA[strA.Length - sIndex]);
            }
            else
            {
                Console.WriteLine(strA[strA.Length - sIndex]);
            }

        }
        static void Index2()
        {

            int[] numA = { 0, 341, 441, 54, 133, 212, 13, 134 };
            Console.WriteLine("Choose an INDEX from 0 to 8"); // index 0 starts at 134, index 1 is 13 and so on
            int nIndex = int.Parse(Console.ReadLine());
            if (nIndex > 8)
            {
                Console.WriteLine("invalid INDEX. Last chance. \nPlease choose INDEX 0 thru INDEX 8");
                nIndex = int.Parse(Console.ReadLine());
                Console.WriteLine(numA[numA.Length - nIndex]);
            }
            else
            {
                Console.WriteLine(numA[numA.Length - nIndex]);
            }
            
       
          
        }
        static void List1()
        {
            List<int> xList = new List<int>();
            xList.Add(0);
            xList.Add(643);
            xList.Add(6);
            xList.Add(342);
            Console.WriteLine("Choose an INDEX from 0 to 3"); //index starts at 0 342, index 1 at 
            int lIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(xList[lIndex]);
            Console.ReadLine();
        }
    }
}
