using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDays
{

   
    class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday, Monday, Tuesday, Wednesday, Thurday, Friday, Saturday
        }
        static void Main(string[] args)
        {
            Console.Write("What day of the week is it?   ");
            string input = UppercaseFirst(Console.ReadLine());
            int underlyingValue0 = Convert.ToInt32(DaysOfTheWeek.Sunday);
            int underlyingValue1 = Convert.ToInt32(DayOfWeek.Monday);
            int underlyingValue2 = Convert.ToInt32(DayOfWeek.Tuesday);
            int underlyingValue3 = Convert.ToInt32(DayOfWeek.Wednesday);
            int underlyingValue4 = Convert.ToInt32(DayOfWeek.Thursday);
            int underlyingValue5 = Convert.ToInt32(DayOfWeek.Friday);
            int underlyingValue6 = Convert.ToInt32(DayOfWeek.Saturday);
            try
            {
                if (Enum.IsDefined(typeof(DaysOfTheWeek), input) || Enum.IsDefined(typeof(DaysOfTheWeek), Convert.ToInt32(input))) 
                {
                    Console.WriteLine("That has a value");
                }
                else
                {
                    Console.WriteLine("wtf did you do");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");

            }
            string UppercaseFirst(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return string.Empty;
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();
            }



           /* EXPIREMENTALS
            {
                if (Convert.ToBoolean(input) == Convert.ToBoolean(underlyingValue0))
                {
                    Console.WriteLine("YES");
                }
                if (input == Convert.ToBoolean(underlyingValue1))
                {
                    Console.WriteLine("Thats correct!!!");
                }
                if (input == Convert.ToBoolean(underlyingValue3))
                {
                    Console.WriteLine("Thats correct!!!");
                }
                if (input == Convert.ToBoolean(underlyingValue4))
                {
                    Console.WriteLine("Thats correct!!!");
                }
                if (input == Convert.ToBoolean(underlyingValue5))
                {
                    Console.WriteLine("Thats correct!!!");
                }
                if (input == Convert.ToBoolean(underlyingValue6))
                {
                    Console.WriteLine("Thats correct!!!");
                }
                else
                {
                    Console.Beep();
                }
            }
            catch
            {
                Console.WriteLine("WTF try again.");
            }
            */
            Console.ReadLine();
        }

    }
}
