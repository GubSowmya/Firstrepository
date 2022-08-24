using System;
using System.ComponentModel;

namespace Day6
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter Employee number");
            emp.eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name");
            emp.ename = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Employee salary");
            emp.esal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee department number");
            emp.edeptno = Convert.ToInt32(Console.ReadLine());

            emp.AcceptData(int eno, string ename, int esal, int edeptno);
            Console.WriteLine("Employee details are : ");
            emp.Display();
            Console.ReadLine();



        }

        struct Employee
        {
            int Empnum, Esal, Edept;
            string EmpName;
            public static AcceptData(int empno, string ename, int sal, int deptno)
            {
                Empnum = empno;
                EmpName = ename;
                Esal = sal;
                Edept = deptno;
                
            }
            public static Display()
            {
                Console.WriteLine("Employee number is :", +Empnum);
                Console.WriteLine("Employee Name is :", +EmpName);
                Console.WriteLine("Employee salary is :", +Esal);
                Console.WriteLine("Employee Dept number is :", +Edept);

            }
        }
    }

}


empno, ename, sal, deptno
