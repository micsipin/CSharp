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
            string[] strA = new string[] { "red", "yellow", "blue", "purple", "brown", "aqua", "green", "black" }; // index 0 starts at black, index 1 is green and so on
            Console.WriteLine("Choose an INDEX from 0 to 8");
            int sIndex = int.Parse(Console.ReadLine());
            if (sIndex > 8)

            {
                Console.WriteLine("invalid INDEX. Last chance. \nPlease choose INDEX 0 thru INDEX 8");
                sIndex = int.Parse(Console.ReadLine());
                Console.WriteLine(strA[sIndex]);
            }
            else
            {
                Console.WriteLine(strA[sIndex]);
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
                Console.WriteLine(numA[nIndex]);
            }
            else
            {
                Console.WriteLine(numA[nIndex]);
            }
        }
        static void List1()
        {
            List<string> strList = new List<string>();
            strList.Add("dog");
            strList.Add("cat");
            strList.Add("fish");
            strList.Add("midget");

            Console.WriteLine("Choose an INDEX from 0 to 3"); 
            string lIndex = Console.ReadLine();
            Console.WriteLine(strList[int.Parse(lIndex)]);
            Console.ReadLine();
        }

    }
}
