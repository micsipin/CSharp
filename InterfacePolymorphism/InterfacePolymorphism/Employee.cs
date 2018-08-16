using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePolymorphism
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: [{FirstName} {LastName}]");
        }
        public void Quit()
        {
            Console.WriteLine("Quit");
            Console.ReadLine();
        }
    }
}

