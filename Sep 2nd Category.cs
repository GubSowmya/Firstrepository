using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
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

        public List<Product> _productlist;
        public List<Product> ProductList
        {
            get { return _productlist; }
            set { _productlist = value; }
        }

        //Write a AddCategory() in the Category Class, accepting catid, catname,description
        //and assign them to respective properties.
        public void AddCategory(int _catid, string _catname, string _description)
        {
            this.CategoryID = _catid;
            this.CategoryName = _catname;
            this.Description = _description;
        }

        // Print the list of products along with category details and to do this add a method to the category class, method name DisplayDetails().

        public void DisplayDetails()
        {
            Console.WriteLine("CategoryID :", _catid);
            Console.WriteLine("CategoryName :", _catname);

            foreach (var i in ProductList)
            {
               // Console.WriteLine("Product ID: " + i._pid);
                Console.WriteLine("Product Name: " + i.ProductName);

            }
        }
    }

}
