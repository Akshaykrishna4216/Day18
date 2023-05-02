using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 digit number");
            int n=int.Parse(Console.ReadLine());
            
             int sum = 0;
            int temp = n;
           while (n > 0)
            {
                int num = n % 10;
                sum =sum + (int)Math.Pow(num, 3);
                n = n / 10;
            }
            if(sum == temp) 
            {
                Console.WriteLine("number is armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong number");
            }
        }
    }
}
