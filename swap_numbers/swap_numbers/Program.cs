using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b=int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            
           
            Console.WriteLine("a=" + a + " b=" + b);
        }
    }
}
