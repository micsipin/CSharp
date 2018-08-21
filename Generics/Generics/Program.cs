using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            bool Equal = Employee<int>.employee<int>(1, 4);
            if (Equal)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Employee<string> emp00 = new Employee<string>();
            Employee<int> emp01 = new Employee<int>();
            emp00.ID = 90210;
            emp01.ID = 90028;
            emp00 = new Employee<string>() { FirstName = "Sample", LastName = "Student", ID = 90210 };
            emp01 = new Employee<int>() { FirstName = "Sample2", LastName = "Student2", ID = 90028 };

            emp01.SayName();
            emp01.Things = new List<int>(new int[] { 9, 0, 0, 2, 8 });
            foreach (int Things  in emp01.Things)
            {
                Console.WriteLine(Things);
            }
            emp00.SayName();
            emp00.Things = new List<string>(new string[] { "Nine", "Zero", "Two", "One", "Zero" });
            foreach (string Things in emp00.Things)
            {
                Console.WriteLine(Things);
            }


            //Console.WriteLine(emp == emp2);
            //Console.WriteLine(emp != emp2);


            IQuittable quittable = new Employee<string>();
            Console.WriteLine();
            quittable.Quit();
            Console.Beep();
            Console.ReadLine();         
        }
        
    }
}