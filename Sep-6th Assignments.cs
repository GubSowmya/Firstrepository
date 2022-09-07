using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Sep_6th_Assignments
{



    // create a abstract class Person, with a abstract method Work.
    // Implment the Person class in multiple classes like Employee, Manager and clerk.
    public abstract class Person
    {
        public abstract void Work();
        public void workplace()
        {
            Console.WriteLine("Woking Location: Pune");
        }
    }
    public class Employee : Person
    {
        public override void Work()
        {
            Console.WriteLine("Employee : John");
        }
    }
    public class Manager : Person
    {
        public override void Work()
        {
            Console.WriteLine("Manager: Smith");
        }
    }
    public class Clerk : Person
    {
        public override void Work()
        {
            Console.WriteLine("Clerk: clam");
        }
    }


    //  Create a interface IBank with method PrintBalance, CalculateInterest

    public interface IBank
    {
        void PrintBalance();
        void CalculateInterest();
    }

    //Create 2 classes Saving and Current.
    //Inherit and implement Ibank interface.

    public class Bank : IBank
    {

        static int amt = Convert.ToInt32(Console.ReadLine());
        private int _deposit;
        public int Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }
        private int _withdraw;
        public int Withdraw
        {
            get { return _withdraw; }
            set
            {
                if (Total() < amt)
                {
                    Withdraw = 0;
                }
                {
                    Withdraw = value;
                }
            }
        }
        public int Total()
        {
            int total;
            total = Deposit + amt - Withdraw;
            return total;
        }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public void NoOfDays()
        {
            TimeSpan t = DateTime.Now - Date;
            Console.WriteLine("No of Days: " + t.TotalDays);
        }

        ///Create a interface IBank with method PrintBalance, CalculateInterest
        public void CalculateInterest()
        {
            int s = Total();
            Console.WriteLine("Enter Interest Rate: ");
            int m = Convert.ToInt32(Console.ReadLine());
            float i = (s * m) / 100;
            Console.WriteLine("Interest rate per year is:  " + i);
        }
        public void PrintBalance()
        {
            int n = Total();
            Console.WriteLine("Yotal Total Balance: " + n);
        }
    }
    public class Savings : Bank, IBank
    {
        public void CalculateInterest()
        {
            int m = base.Total();
            float i = (4 * m) / 100;
            Console.WriteLine("Saving Interest rate per year is:  " + i);
        }
        public void PrintBalance()
        {
            int m = base.Total();
            float i = (4 * m) / 100;
            float a = m + i;
            Console.WriteLine("Savings Amount is:  " + a);
        }
    }
    public class Current : Bank, IBank
    {
        public void CalculateInterest()
        {
            int m = base.Total();
            float i = (2 * m) / 100;
            Console.WriteLine("Current Interest rate per year is:  " + i);
        }
        public void PrintBalance()
        {
            int m = base.Total();
            float i = (2 * m) / 100;
            float a = m + i;
            Console.WriteLine("Current Amount is:  " + a);
        }
    }

    //Write extension methods for Saving and Current Account class to Withdraw, taking amt as parameter.
    public static class extension
    {
        public static int deposit(this int i)
        {
            return i;
        }
        public static int withdraw(this int i)
        {
            return i;
        }

    }
}



