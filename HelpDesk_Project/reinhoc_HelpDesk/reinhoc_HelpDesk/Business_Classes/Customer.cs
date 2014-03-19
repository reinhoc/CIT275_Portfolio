using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinhoc_HelpDesk.Business_Classes
{
    class Customer
    {
        #region [Private Fields]
        private int _custID;
        private string _custName;
        private string _custAddress;
        private string _custState;
        private int _custZip;
        #endregion

        #region [Public Properties]
        public int CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }

        public string CustName
        {
            get { return _custName; }
            set { _custName = value; }
        }

        public string CustAddress
        {
            get { return _custAddress; }
            set { _custAddress = value; }
        }

        public string CustState
        {
            get { return _custState; }
            set { _custState = value; }
        }

        public int CustZip
        {
            get { return _custZip; }
            set { _custZip = value; }
        }
        #endregion

        #region [Constructors]
        public void Customers()
        {

        }
        #endregion
    }
}
