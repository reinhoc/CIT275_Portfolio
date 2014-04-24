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
    /// A Help Desk Customer
    /// </summary>
    public class Customer
    {
        #region [Private Fields]
        private int _custID;
        private string _custName;
        private string _custAddress;
        private string _custState;
        private int _custZip;
        #endregion

        #region [Public Properties]
        /// <summary>
        /// Customer ID
        /// </summary>
        public int CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }
        /// <summary>
        /// Customer Name
        /// </summary>
        public string CustName
        {
            get { return _custName; }
            set { _custName = value; }
        }
        /// <summary>
        /// Customer Address
        /// </summary>
        public string CustAddress
        {
            get { return _custAddress; }
            set { _custAddress = value; }
        }
        /// <summary>
        /// Customer State
        /// </summary>
        public string CustState
        {
            get { return _custState; }
            set { _custState = value; }
        }
        /// <summary>
        /// Customer Zip
        /// </summary>
        public int CustZip
        {
            get { return _custZip; }
            set { _custZip = value; }
        }
        #endregion

        #region [Constructors]
        /// <summary>
        /// Default Customer
        /// </summary>
        public void Customers()
        {

        }
        #endregion
    }
}
