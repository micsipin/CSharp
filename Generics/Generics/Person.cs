using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Paygrade { get;  set; }
        public string Shift { get;  set; }
        public string Misc { get;  set; }
        public abstract void SayName();
        //public List<T> Things { get; set; }
    }
}