using System;
using System.Collections.Generic;
using System.Text;



namespace Generics
{
        
    public class Employee<T> : Person, IQuittable
    {

        public List<T> Things { get; set; }

        public static bool employee<T>  (T Value1, T Value2)
        {
            return Value1.Equals(Value2);

        }
        public override void SayName()
        {

            Console.WriteLine($"Name: [{FirstName} {LastName}]\r\nID: [{ID}]");
          
        }
         
        public static bool operator ==(Employee<T> emp, Employee<T> emp2)
        {
            return emp.ID == emp2.ID;
        }
        public static bool operator !=(Employee<T> emp, Employee<T> emp2)
        {
            return Convert.ToBoolean(emp.ID != emp2.ID);
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