using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Handson
{
    internal class program5
    {
        
       enum deptnames
    {
        purchase = 1,
        Sales = 2,
        Triangle = 3,
        Accounts = 4

    }
        static void Main(string[] args)
        {
            Console.WriteLine("enter department");
            int deptnames = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", deptnames);

            //int day =(int) Weekdays.Friday;
            //Console.WriteLine(day);

            Console.WriteLine("enter day");
            int day = Convert.ToInt32(Console.ReadLine());

            var nameofDay = (Weekdays)day;
            Console.WriteLine(nameofDay);
        }
}


    switch ()
