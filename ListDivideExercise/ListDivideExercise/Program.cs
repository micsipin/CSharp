using System.Collections.Generic;
using System;

namespace ListDivideExercise
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> dList = new List<int>();
                dList.Add(20);
                dList.Add(33);
                dList.Add(14);
                Console.WriteLine("pick a number");
                int uNum = Convert.ToInt32(Console.ReadLine());
                // Loop through List with foreach.
                foreach (int dNum in dList)
                {
                    System.Console.WriteLine(dNum / uNum);
                }
                
            } 
           catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            
        }
    }
}
