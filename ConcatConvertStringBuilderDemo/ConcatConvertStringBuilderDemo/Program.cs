using System;
using System.Text;

namespace ConcatConvertStringBuilderDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            
            string con, cat, enate;

            con = "enate";
            cat = "cat";
            enate = "con";

            string x = String.Concat(enate, cat, con);
            Console.WriteLine(x); //concatenation for answer #1
            Console.Write("\t");

            string up = x.ToUpper(); //string to uppercase for answer #2
            Console.WriteLine("{1},\n{0}", x, up);
            Console.ReadLine();
            
            
            StringBuilder sbuilder = new StringBuilder(100); //paragraph
            sbuilder.Append(" Today, I spent ");
            sbuilder.Append("some time learning \n some new th");
            sbuilder.Append("ings.");
            sbuilder.Append(" For example, one of \n the things is how to \n make a \n new line in the console.");

            Console.WriteLine(sbuilder);
            Console.ReadLine();
        }
    }
}


