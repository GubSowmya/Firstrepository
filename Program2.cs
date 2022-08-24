using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Handson
{
    internal class Program2
    {
        public static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter the 1st number");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2st number");
            n2 = Convert.ToInt32(Console.ReadLine());

            
            int res = add(n1, n2);
            Console.WriteLine("Sum of Two numbers is :" + res);
        }
        static int add(int i, int j)
        {
             return i + j;

        }
    }
}

