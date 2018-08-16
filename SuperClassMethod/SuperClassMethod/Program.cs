using System;

namespace SuperClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee () { firstName = "Sample", lastName = "Student" };
            emp.SayName();
            Console.ReadLine();
        

        }

    }
}
