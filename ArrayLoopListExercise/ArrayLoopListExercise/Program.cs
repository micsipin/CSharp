using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayLoopListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Create a one-dimensional Array of strings. Ask the user 
             * to input some text. Create a loop that goes through each string
             * in the Array, adding the user’s text to the string. Then create 
             * a loop that prints off each string in the Array on a separate line.
             */

            string uInput;
            string[] strA = new string[] { "think", "work", "do" }; //

            Console.WriteLine("type a word");
            uInput = Console.ReadLine();
            strA[0] = uInput;
            strA[1] = uInput;
            strA[2] = uInput;
            //foreach (string addTo in strA)
            //{
            //    Console.WriteLine();
            //}

            /*2. Create an infinite loop
             *&
             *3. Fix the infinite loop so it will execute.

            for (int x = 0; x - 1 < x++;) 
            {
                foreach (string word in strA)
                {
                    Console.WriteLine(uInput + word);
                }
            }
            */

            /*4. Create a loop where the comparison used to determine 
                * whether to continue iterating the loop is a “<” operator.
                */
            for (int i = 0; i < 3; i++)
                foreach (string word in strA)
                {
                    Console.WriteLine(strA[0]);
                }
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            /*5. Create a loop where the comparison used to determine 
                * whether to continue iterating the loop is a “<=” operator.
                */
            Console.WriteLine();
            int length = 3;
            for (int i = 0; i <= length; i++)
            {
                foreach (string word in strA)
                {
                    Console.WriteLine("looping");
                }
            }
            Console.WriteLine();
            /*6. Create a List of strings where each item in the list is 
                * unique. Ask the user to select text to search for in the 
                * List. Create a loop that iterates through the loop and then 
                * displays the index of the array that contains matching 
                * text on the screen.
                */

            Console.ReadLine();
            List<string> sList = new List<string>() { "circle", "square", "triangle", "rectangle" };
            Console.WriteLine("Type in a basic shape.");
            string sInput = Console.ReadLine();
            if (sList.Contains(sInput))
            {
                Console.WriteLine("shape was found");
                for (int i = 0; i < sList.Count; i++)
                {
                    Console.WriteLine($"{i} = {sList[i]}");
                }
            }

            else
            /*7. Add code to that above loop that tells a user 
                * if they put in text that isn’t in the List.
                */
            {
                Console.WriteLine("not a shape or not on list.");
            }
        
            /*9.Create a List of strings that has at least two 
             * identical strings in the List. Ask the user to select 
             * text to search for in the List.Create a loop that 
             * iterates through the loop and then displays the 
             * indices of the array that contain matching text
             * on the screen.
             */
            Console.ReadLine();
            List<string> sList2 = new List<string>() { "apple", "orange", "banana", "grape","mango", "watermelon" };
            Console.WriteLine("Type in a fruit.");
            string sInput2 = Console.ReadLine();
            if (sList2.Contains(sInput2))
            {
                Console.WriteLine("fruit was found");
                for (int i = 0; i < sList.Count; i++)
                {
                    Console.WriteLine($"{i} = {sList2[i]}");
                }
            }
            else
            /*10. Add code to that above loop that tells a 
             * user if they put in text that isn’t in the List.
             */
            { 
                Console.WriteLine("Thats not a fruit on the list.");
            }
            /*11.Create a List of strings that has at least two
            * identical strings in the List. Create a foreach loop that 
            * evaluates each item in the list, and displays a message
            * showing the string and whether or not it has already 
            * appeared in the list.
            */
            Console.ReadLine();
            List<string> carColors = new List<string>() { "red", "black", "silver", "white", "blue", "gray", "yellow", "white", "blue" };
            List<string> usedColors = new List<string>();
                foreach (string color in carColors)
                {
                    Console.Write(color);
                    foreach (string used in usedColors)
                    {
                        if (used == color)
                        {
                            Console.Write(" already used");
                        }
                    }
                    Console.WriteLine();
                    usedColors.Add(color);
                }
                Console.ReadLine();
        }
    }
}






