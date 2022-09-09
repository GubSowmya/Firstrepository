using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSLib
{
   public delegate void Delegate(int id);
    public class Employees
    {
        private int _id;

        public int EmpID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _empname;
        public string EmpName
        {
            get { return _empname; }
            set { _empname = value; }
        }
        private int _deptno;

        public int DeptNo
        {
            get { return _deptno; }
            set { _deptno = value; }
        }
        private int _sal;

        public int Salary
        {
            get { return _sal; }
            set { _sal = value; }
        }
        public int mgr;

        public int MGR
        {
            get { return mgr; }
            set { mgr = value; }
        }

        public static event Delegate Event;
        public void Add(int id)
        {
            EmpID = id;
            Console.WriteLine("Add Details of Employee ID: " + EmpID);
            Console.WriteLine("Enter Employee Name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee DeptNo: ");
            DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee MGR: ");
            MGR = Convert.ToInt32(Console.ReadLine());
        }

        public void update(int id)
        {
            EmpID = id;
            Console.WriteLine("Add Details of Employee ID for update: " + EmpID);
            Console.WriteLine("Enter Employee Name for update: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee DeptNo for update: ");
            DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary for update: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee MGR for update: ");
            MGR = Convert.ToInt32(Console.ReadLine());


        }

        public void delete(int id)
        {
            EmpID = id;

            if (EmpID != 0)
            {
                EmpID = 0;
                EmpName = string.Empty;
                DeptNo = 0;
                Salary = 0;
                MGR = 0;
            }

        }         
    }
}
