using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingOperator
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public abstract void SayName();
    }
}