using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaJoeList
{
    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee() {FName = "Joe", LName = "Mommafurd", Id = 1 },
                new Employee() {FName = "Milly", LName = "Mumms", Id = 2 },
                new Employee() {FName = "Boris", LName = "Wellington", Id = 3 },
                new Employee() {FName = "Mary Anne ", LName = "Abdilai", Id = 4 },
                new Employee() {FName = "Mohammad", LName = "Smith", Id = 5 },
                new Employee() {FName = "Steve", LName = "Nyghuenzhuzi ", Id = 6 },
                new Employee() {FName = "Alberto", LName = "Roberto", Id = 7 },
                new Employee() {FName = "Johnny", LName = "Jones", Id = 8 },
                new Employee() {FName = "Pete", LName = "Peterson", Id = 9 },
                new Employee() {FName = "Joe", LName = "Jones", Id = 10 }
            };
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in empList)
            {
                if (employee.FName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            
            List<Employee> lambdaJoe = empList.Where(x => x.FName == "Joe").ToList();
            List<Employee> lambdaFive = empList.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}