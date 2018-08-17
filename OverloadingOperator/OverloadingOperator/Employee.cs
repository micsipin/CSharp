using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperator
{
    class Employee : Person, IQuittable
    {
        //public  int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine($"Name: [{FirstName} {LastName}]\r\nID: [{ID}]");
            Console.WriteLine($"Name: [{FirstName} {LastName}]\r\nID: [{ID}]");
        }
        public static bool operator==(Employee emp, Employee emp2)
        {
            return emp.ID==emp2.ID;
        }
        public static bool operator !=(Employee emp, Employee emp2)
        {
            return Convert.ToBoolean(emp.ID!= emp2.ID);
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
        public void Quit()
        {
            Console.WriteLine("Quit");
            Console.ReadLine();
        }
    }
}