using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSLib;

namespace Sep_8th_Assignments
{
    public class Class1
    {
      public static void Main(String[] args)
        {

            Department dpt = new Department();
            Employees emp = new Employees();

            emp.Add(501);
            emp.update(501);

            Console.WriteLine("Enter Number of Employees in Dept: ");
            int no = Convert.ToInt32(Console.ReadLine());
            if(no > 10)
            {
                Console.WriteLine("Can not add more than ten employees");
            }
            else
            {
                emp.Add(no);
            }

           List<Employees> list = new List<Employees>();
            Console.WriteLine(list);
            

        }






    }
}
