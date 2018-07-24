using System;

namespace IncomeComparisonDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            float hourRate1, weeklyHours1, hourRate2, weeklyHours2;
            
            //person1
            Console.WriteLine("Anonymous Income Comparison Program;");
            Console.WriteLine("");
            Console.WriteLine("############## PERSON 1 ###############");
            Console.WriteLine("");
            Console.WriteLine("Hourly rate?");
            hourRate1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours per week?");
            weeklyHours1 = float.Parse(Console.ReadLine());
            int salary1 = Convert.ToInt32(hourRate1 * weeklyHours1 * 52);
            Console.WriteLine("Annual Salary for PERSON 1 is");
            Console.WriteLine(salary1);
            Console.WriteLine();

            //person2
            Console.WriteLine("");
            Console.WriteLine("############## PERSON 2 ###############");
            Console.WriteLine("");
            Console.WriteLine("Hourly rate?");
            hourRate2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours per week?");
            weeklyHours2 = float.Parse(Console.ReadLine());
            int salary2 = Convert.ToInt32(hourRate2 * weeklyHours2 * 52);
            Console.WriteLine("Annual Salary for PERSON  is");
            Console.WriteLine(salary2);
            Console.WriteLine();

            //comparison

            Console.WriteLine("############# COMPARISON ##############");
            Console.WriteLine("Does PERSON 1 make more than PERSON 2?");
            Console.WriteLine();
            bool compare = (salary1 > salary2);
            if (salary1 > salary2)
                Console.WriteLine("Yes");
            else if (salary1 < salary2)
                Console.WriteLine("No");
            else Console.WriteLine("Both PERSONS salaries are equal.");
            Console.ReadLine();
            
        }
    }
}