using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract  
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { firstName = "Sample", lastName = "Student" };
            emp.SayName();
            Console.ReadLine();


        }

    }
}
