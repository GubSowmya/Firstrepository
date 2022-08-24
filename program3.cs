


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Handson
{
    internal class Program3
    {
        public static void Main(string[] args)
        {

            employee emp = new employee();

            Console.WriteLine("Enter employee number :");
            emp.a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name :");
            emp.b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary :");
            emp.c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Dept Number :");
            emp.d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Details are:");
            emp.DisplayInfo();
            Console.ReadLine();





        }
        struct employee
        {
            int _empno;
            public int a
            {
                get
                {
                    return _empno;
                }
                set
                {
                    _empno = value;
                }
            }

            string _ename;
            public string b
            {
                get { return _ename; }
                set { _ename = value; }
            }

            int _sal;
            public int c
            {
                get { return _sal; }
                set { _sal = value; }
            }

            int _deptno;
            public int d
            {
                get { return _deptno; }
                set { _deptno = value; }
            }

            public void DisplayInfo()
            {
                Console.WriteLine(_empno);
                Console.WriteLine(_ename);
                Console.WriteLine(_sal);
                Console.WriteLine(_deptno);

            }
        }
    }
}
