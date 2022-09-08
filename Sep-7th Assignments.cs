using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Sep_7th;

namespace Sep__7th_Assignments
{
    internal class Program
    {
        public class Calc

        {
            public delegate void cal(int a, int b);


            public void sum(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("sum :" + sum);
            }

            // method "subtract"
            public void subtract(int a, int b)
            {
                int sub = a - b;
                Console.WriteLine("sub :" + sub);
            }
            public void Mul(int a, int b)
            {
                int Mul = a * b;
                Console.WriteLine("Mul :" + Mul);
            }
        }
        public static void Main(string[] args)
        {
            

            Calc obj = new Calc();

           int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Delegate[] s = new Delegate[3] { obj.sum, obj.subtract, obj.Mul };
            Delegate s3 = (Delegate)MulticastDelegate.Combine(s);
            s3(a, b);
        }

    }
}
