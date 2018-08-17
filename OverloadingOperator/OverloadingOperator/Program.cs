using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OverloadingOperator
{
    class Program
    {
       static void Main(string[] args)
        {
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student", ID = 90210 };
            Employee emp2 = new Employee() { FirstName = "Sample2", LastName = "Student2", ID = 90028 };
            emp.SayName();
            emp2.SayName();
            Console.WriteLine(emp == emp2);
            Console.WriteLine(emp != emp2);
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}