using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Enter the 1st number");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2st number");
        b = Convert.ToInt32(Console.ReadLine());

        addition(a, b);
    }

    static void addition(int p, int q)
    {
        int res = p + q;
        Console.WriteLine("result of two numbers sum is :" + res);

    }

}

// program -2

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


// program -3

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
        
            // program -4
            
            
