using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamWriterNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input some numbers");
            string uInput = Console.ReadLine();
            

            File.WriteAllText(@"C:\\Users\\Tech Academy Student\\Desktop\\log.txt", uInput);
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "consoleLogged.txt")))
            {
                outputFile.WriteLine(uInput);
            }
            Console.WriteLine("Your input, " + uInput + "  was printed to a .txt file in your MyDocuments folder, under consoleLogged.txt");
            Console.ReadLine();
        }
    }
}

