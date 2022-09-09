using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSLib
{
    public class Department
    {
        private int _deptno;

        public int DeptNo
        {
            get { return _deptno; }
            set { _deptno = value; }
        }
        private string _dname;

        public string DeptName
        {
            get { return _dname; }
            set { _dname = value; }
        }
        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

    }
}
