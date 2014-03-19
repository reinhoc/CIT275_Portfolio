using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinhoc_HelpDesk.Business_Classes
{
    class Employee
    {
        #region [Private Fields]
        private int _empID;
        private string _empFName;
        private string _empLName;
        private string _empUName;
        #endregion

        #region [Public Properties]
        public int EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public string EmpFName
        {
            get { return _empFName; }
            set { _empFName = value; }
        }

        public string EmpLName
        {
            get { return _empLName; }
            set { _empLName = value; }
        }

        public string EmpUName
        {
            get { return _empUName; }
            set { _empUName = value; }
        }
        #endregion

        #region [Constructors]
        public void Employees()
        {

        }
        #endregion
    }
}