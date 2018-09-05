using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining1
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor A");
        }
        public A(string z)
        {
            Console.WriteLine("Constructor A with param = {0}",z); 
        }
        public A(string z, string y)
        {
            Console.WriteLine("Constructor A with param = {0}",z,y);
        }
    }
    class B:A
    {
        public B():base()
        {
            Console.WriteLine("Constructor B");
        }
        public B(string z):base(z)
        {
            Console.WriteLine("Constructor B with para = {0}", z);
        }
        public B(string z, string y):base(z,y)
        {
            Console.WriteLine("Constructor B with params = {0} & {1}", z, y);
        }
    }

    class Program
    {
        const string constV = "Const value";
       
        static void Main(string[] args)
        {
            Console.WriteLine(constV);
            var dict = new Dictionary<string, int>();
            dict.Add("var dictionary item A", 1);
            dict.Add("var dictionary item B", 2);
            dict.Add("var dictionary item C", 3);
            foreach (KeyValuePair<string,int> item in dict)
            {
                Console.WriteLine(item.Key, item.Value);
            }
            
            //B b = new B();
            B b2 = new B("param 1", "param 2");
            Console.ReadLine();
        }
    }
}
