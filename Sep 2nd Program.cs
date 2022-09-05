using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Sep_2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category ctg = new Category();

            ctg.CategoryID = 501;
            ctg.CategoryName = "Pens";
            ctg.Description = "Writting";

            Console.WriteLine(ctg.CategoryID);
        }
        public class Category
        {
            //Create a class Category with catid, catname,description
            int _catid;
            string _catname;
            string _description;

            public int CategoryID
            {
                get { return _catid; }
                set { _catid = value; }
            }

            public string CategoryName
            {
                get { return _catname; }
                set { _catname = value; }
            }

            public string Description
            {
                get { return _description; }
                set
                {
                    _description = value;
                }

            }
        }
    }
}
