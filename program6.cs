using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Handson
    {
        internal class Program6
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Enter Department Name for number: ");
                string dname = Console.ReadLine();
                if (dname == "Purchase")
                {
                    int dep = (int)deptnames.Purchase;
                    Console.WriteLine(dep);
                }
                else if (dname == "Sales")
                {
                    int dep = (int)deptnames.Sales;
                    Console.WriteLine(dep);
                }
                else if (dname == "Training")
                {
                    int dep = (int)deptnames.Training;
                    Console.WriteLine(dep);
                }
                else if (dname == "Accounts")
                {
                    int dep = (int)deptnames.Accounts;
                    Console.WriteLine(dep);
                }
                else
                    Console.WriteLine("not a department");
                Console.ReadLine();
            }
            enum deptnames
            {
                Purchase = 1,
                Sales = 2,
                Training = 3,
                Accounts = 4
            }

        }
    }



