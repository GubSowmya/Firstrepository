using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Handson
{
    internal class program7
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter i : ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter j : ");
                int j = Convert.ToInt32(Console.ReadLine());

                int Divans = i / j;
                Console.WriteLine(Divans);

            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
        }

}
}
