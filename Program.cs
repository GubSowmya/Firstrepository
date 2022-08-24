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
