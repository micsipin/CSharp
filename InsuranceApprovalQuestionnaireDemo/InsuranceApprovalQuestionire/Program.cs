using System;

namespace InsuranceApprovalQuestionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; int infractions; bool hasDUI; bool isQualitfied;

            Console.WriteLine("Tech Academy Insurance");
            Console.WriteLine("Pre Approval Questionire for Auto Insurance");
            Console.WriteLine();
            Console.WriteLine("Please answer the following questions.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            if (dui.ToLower() == "yes")
            {
                hasDUI = true;
            }
            else
            {
                hasDUI = false;
            }
            Console.WriteLine("How many speeding tickets do you have?");
            infractions = Int16.Parse(Console.ReadLine());
            Console.WriteLine();
            if (isQualitfied = (age < 15) || (infractions > 3) || (hasDUI == true))
            {
                Console.WriteLine("False. You are either underage and/or have 3 or more speeding tickets or may have a DUI. You are ineligible.");
            }
            else 
            {
                Console.WriteLine("True. You are eligible.");
            }
            Console.ReadLine();

        }
    }
}

        