using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace replace_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            int rem, rev = 0;
            
            while(n>0)
            {
                int num=n%10;
                if(num==0)
                {
                    num = 5;
                }
                 sum = sum * 10 + num;
                n = n / 10;
            }
            while(sum>0)
            {
                rem=sum%10;
                rev=rev*10+rem;
                sum = sum / 10;
                
            }
            Console.WriteLine(rev);
  
        }
    }
}
