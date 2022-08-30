using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26th_HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students[] std = new Students[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Detals of Student {0}: ", i);
                Console.WriteLine("Enter Student ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Department Number:");
                int dept = Convert.ToInt32(Console.ReadLine());
                std[i].AcceptData(id, name, dept);
            }

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Student Details are {0}:", j);
                std[j].DisplayDetails();
            }
            Console.ReadLine(); 
        }

        struct Students
        {
           
                int Sno, Deptno;
                string Sname;
                public void AcceptData(int sno, string sname, int deptno)
                {
                    Sno = sno;
                    Sname = sname;
                    Deptno = deptno;

                }
                public void DisplayDetails()
                {
                    Console.WriteLine("Student ID: " + Sno);
                    Console.WriteLine("Student Name: " + Sname);
                    Console.WriteLine("Student Department Number: " + Deptno);

                }



        }

        // program - 2


static void Main(string[] args)
    {
        Students[] std = new Students[10];
        for (int i = 0; i < std.Length; i++)
        {
            std[i] = new Students();
            Console.WriteLine("Enter Detals of Student {0}: ", i);
            Console.WriteLine("Enter Student ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Department Number:");
            int dept = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter College Name:");

            std[i].AcceptData(id, name, dept);
        }

        for (int i = 0; i < std.Length; i++)
        {
            Console.WriteLine("Details of Students {0}:", i);
            std[i].DisplayDetails();

        }
        Console.ReadLine();
    }
    //program -3



 
        List<Products> product = new List<Products>();
        product.Add(new Products { Pid = 1, Pname = "Coffee", cost = 100 });
        product.Add(new Products { Pid = 2, Pname = "Sugar", cost = 200 });
        product.Add(new Products { Pid = 3, Pname = "Milk", cost = 300 });
        
        foreach (var i in product)
        {
            Console.WriteLine("Product ID: " + i.Pid);
            Console.WriteLine("Product Name: " + i.Pname);
            Console.WriteLine("Product Price: " + i.Price);
        }
      

        Console.WriteLine("After Removing Product : ");
        product.Remove(new Products { Pid = 2, Pname = "Sugar", cost = 200 });
        foreach (var j in product)
        {
            Console.WriteLine("Product ID: " + j.Pid);
            Console.WriteLine("Product Name: " + j.Pname);
            Console.WriteLine("Product Price: " + j.cost);
        }

        Console.ReadLine();

//program  - 4

static void Main(string[] args)

{

    //creation of the empty linkedlist

    LinkedList<string> linkedList = new LinkedList<string>();

    //add the element at the first position

    linkedList.AddFirst("one");

    // add node at the last position

    var nodeThree = linkedList.AddLast("three");

    // add node before the given element

    linkedList.AddBefore(nodeThree, "two");

    // add node after given node

    linkedList.AddAfter(nodeThree, "four");

    //display the list-linkedlist

    Console.WriteLine("The first list is as:");

    foreach (string value in linkedList)

    {

        Console.WriteLine(value);

    }

    //use of contain() method to find whether the node is present in the list or not

    Console.WriteLine("The node one contain in the list:" + linkedList.Contains("one"));

    Console.WriteLine("The node six contain in the list:" + linkedList.Contains("six"));

    //remove the node from the list

    linkedList.Remove("three");

    //remove the first node from the list

    linkedList.RemoveFirst();

    //remove the last node from the list

    linkedList.RemoveLast();

    Console.WriteLine("The list is as:");

    foreach (string value in linkedList)

    {

        Console.WriteLine(value);

    }

    linkedList.Clear();

    Console.WriteLine("The list is now empty");

    foreach (string value in linkedList)

    {

        Console.WriteLine(value);

    }
























}


  


