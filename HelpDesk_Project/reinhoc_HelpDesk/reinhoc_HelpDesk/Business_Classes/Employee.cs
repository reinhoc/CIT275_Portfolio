using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinhoc_HelpDesk.Business_Classes
{
    [ExcludeFromCodeCoverage]
    /// <summary>
    /// A Help Desk Employee
    /// </summary>
    public class Employee
    {
        #region [Private Fields]
        private int _empID;
        private string _empFName;
        private string _empLName;
        private string _empUName;
        #endregion

        #region [Public Properties]
        /// <summary>
        /// Employee ID
        /// </summary>
        public int EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }
        /// <summary>
        /// Employee First Name
        /// </summary>
        public string EmpFName
        {
            get { return _empFName; }
            set { _empFName = value; }
        }
        /// <summary>
        /// Employee Last Name
        /// </summary>
        public string EmpLName
        {
            get { return _empLName; }
            set { _empLName = value; }
        }
        /// <summary>
        /// Employee UserName
        /// </summary>
        public string EmpUName
        {
            get { return _empUName; }
            set { _empUName = value; }
        }
        #endregion

        #region [Constructors]
        /// <summary>
        /// Default Employee
        /// </summary>
        public void Employees()
        {

        }
        #endregion
    }
}