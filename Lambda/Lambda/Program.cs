using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> empList = new SortedDictionary<string, int>();
            
            //KeyValuePair<SortedDictionary<string, int>, bool> predicate = n => 2  1;
            
            empList.Add("Joe Bradley", 1);
            empList.Add("Russel Wilcox",2);
            empList.Add("Joe Smow",3);
            empList.Add("Samual Powers",4);
            empList.Add("Kelly Kapowski",5);
            empList.Add("Joe Johnson",6);
            empList.Add("Joey Cunnington",7);
            empList.Add("Elmer Duckerson",8);
            empList.Add("Joe Rodgers",9);
            empList.Add("Mohammad Smith",10);
            //foreach (KeyValuePair<string, int> element in empList)
            //{

            SortedDictionary<string, int> empListSort = new SortedDictionary<string, int>();
            foreach (KeyValuePair<string, int> element in empList)
            { 
                 string name = element.Key;
                int id = element.Value;
                Console.WriteLine($"Name: {name}, ID: {id}");
                if (name ==  "Joe")
                {
                    empListSort.Add(empList["Joe"]);
                }
            }
            //for
            //   (int x = 0; x < empList.Count; x++)
            //{
            //    if
            //        { element.Key = "Joe" 

            //     }
            //Dictionary<string, int> empList2 = new Dictionary<string, int>();

            Console.ReadLine();

        }

    }
}
