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
          
          
          
          Console.WriteLine("Enter the username");
          string username = Convert.ToString(Console.ReadLine());
          
          
          Console.WriteLine("Enter the password");
          string password = Convert.ToString(Console.ReadLine());
          
          
          if (username != null && password != null)
                {
                    Console.WriteLine("Logged in successfully");
                   
                    Department dpt = new Department();
                  Employees emp = new Employees();

                  emp.Add(501);
                  emp.update(501);
             
                    Console.WriteLine("Enter Number of Employees in Dept: ");
                    int cnt = Convert.ToInt32(Console.ReadLine());
                    if (cnt <= 10)
                    {
                        for (int i = 0; i < cnt; i++)
                        {
                            Console.WriteLine("Enter Emplyoyee ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Delegate d = new Delegate(emp.Add);
                            d(id);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of Employees can't be more than 10");
                    }
          

           

            

           List<Employees> list = new List<Employees>();
            Console.WriteLine(list);
            

        }






    }
}
