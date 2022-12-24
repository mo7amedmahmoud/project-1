using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            Console.WriteLine("\n    Welcome!");
            Console.WriteLine("\n    Enter The Start :");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("\n    Enter The end :");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("\n    List of prime numbers between "+start +" and "+end +" :");
            for (int i =start; i <= end; i++)
            {
                for ( a = 2; a<=i ;a++) 
                {
                    if (i%a==0)break;     
                }
                if (i == a)
                    Console.WriteLine(i);    
            }
        }   
    }
}
