using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
        public class Product
        {
            int _pid;
            string _pname;
            int _soldcount;
            int _record;

            public int ProductID
            {
                get { return _pid; }
                set { _pid = value; }
            }

            public string ProductName
            {
                get { return _pname; }
                set { _pname = value; }
            }

            public int QuantitySold
            {
                get { return _soldcount; }
                set
                {
                    _soldcount = value;
                }
            }

            public int RecordLevel
            {
                get { return _record; }
                set
                {
                    _record = value;
                }
            }

        public void AddProduct(int _pid, string _prodname)
        {
            this.ProductID = _pid;
            this.ProductName = _prodname;
        }

        //Add a List of products property to the Category Class and assign the products list.

        public List<Product> _prodlist;
        public List<Product> ProductsList
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }
    }



}

