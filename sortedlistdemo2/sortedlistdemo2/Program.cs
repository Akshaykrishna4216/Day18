using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlistdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharashtra", "Mumbai");
            s.Add("Karnataka", "Banglore");
            s.Add("Andhra pradesh", "Hyderabad");
            Console.WriteLine("Elements in sorted list");
           IDictionaryEnumerator e = s.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Key+ "\t" +e.Value);
            }

        }
    }
}
