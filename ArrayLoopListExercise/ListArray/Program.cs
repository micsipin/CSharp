using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            string[] strA = new string[] { "Mac", "Finger", "Bird" }; //
            Console.WriteLine("type \"little\" or \"big\".");
            string aInput = Console.ReadLine();
            Console.WriteLine();
            foreach (string stuff in strA)
            {
                Console.WriteLine(FirstCharToUpper(aInput) + " {0}", stuff);
            }
            Console.ReadLine();

            /*2. Create an infinite loop
            *&
            *3. Fix the infinite loop so it will execute.
            */

            /* commented out due to infinite loop
            for (int x = 0; x - 1 < x++;)
            {
                foreach (string word in strA)
                {
                    Console.WriteLine("buffering");
                }
            }
            */
            for (int x = 0; x == 1; x++) ;
            {
                Console.WriteLine("buffering");
            }
            Console.WriteLine();

            /*4. Create a loop where the comparison used to determine 
            * whether to continue iterating the loop is a “<” operator.
            */
            for (int i = 0; i < 3; i++)
            {
                foreach (string word in strA)
                {
                    Console.WriteLine("Give him the " + strA[2]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            
            /*5. Create a loop where the comparison used to determine 
            * whether to continue iterating the loop is a “<=” operator.
            */
            for (int i = 0; i <= 3; i++)
            {
                foreach (string word in strA)
                {
                    Console.WriteLine("Or a " + strA[1]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            
            /*6. Create a List of strings where each item in the list is 
            * unique. Ask the user to select text to search for in the 
            * List. Create a loop that iterates through the loop and then 
            * displays the index of the array that contains matching 
            * text on the screen.
            */
            List<string> sList = new List<string>() { "Ace", "Queen", "King", "Jack", "Joker", "Kitteh" };
            bool sPass = false;
            while (sPass == false)
            {
                Console.WriteLine("Type item out from list for INDEX posistion");
                sList.ForEach(Console.WriteLine);
                string uInput = FirstCharToUpper(Console.ReadLine());
                for (int a = 0; a < sList.Count; a++)
                {

                    /*8. Add code to that above loop that stops it from executing 
                    * once a match has been found.
                    */
                    if (uInput == sList[a])
                    {
                        Console.WriteLine(FirstCharToUpper(sList[a] + " is Index " + a));
                        sPass = true;
                        break;
                    }
                    
                    /*7. add code to that above loop that tells a user 
                    * if they put in text that isn’t in the list.
                    */
                    else if (!sList.Contains(uInput))
                    {
                        Console.WriteLine("incorrect parameter");
                        Console.ReadLine();
                        break;
                    }
                }
            Console.WriteLine();
            }
            
            /*9.Create a List of strings that has at least two identical 
             * strings in the List. Ask the user to select text to search 
             * for in the List.Create a loop that iterates through the loop 
             * and then displays the indices of the array that contain
             * matching text on the screen.
             */
            List<string> bList = new List<string>() { "upup", "downdown", "left", "right", "left", "right", "A", "B", "Start" };
            bool bPass = false;
            while (bPass == false)
            {
                Console.WriteLine("Type item out from list for INDEX posistion");
                bList.ForEach(Console.WriteLine);
                string bInput = FirstCharToUpper(Console.ReadLine());
                for (int b = 0; b < bList.Count; b++)
                {
                    if (bInput == bList[b])
                    {
                        Console.WriteLine(FirstCharToUpper(bList[b] + " is at " + b));
                        bPass = true;
                        break;
                    }
                    else if (!bList.Contains(bInput))
                    {
                        Console.WriteLine("incorrect parameter");
                        break;
                    }
                }
            }
            
            /* 11. Create a List of strings that has at least two identical
             * strings in the List. Create a foreach loop that evaluates each
             * item in the list, and displays a message showing the string and 
             * whether or not it has already appeared in the list.
             */ 
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
    //Adds uppercase to first letter.
        public static string FirstCharToUpper(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}





                    
                
            
            