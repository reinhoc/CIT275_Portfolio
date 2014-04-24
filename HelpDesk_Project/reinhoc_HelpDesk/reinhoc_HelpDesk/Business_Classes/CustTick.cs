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
    /// An joining of Customers to Tickets
    /// </summary>
    public class CustTick
    {
        #region [Private Fields]
        private int _custID;
        private int _tickID;
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
        /// Ticket ID
        /// </summary>
        public int TickID
        {
            get { return _tickID; }
            set { _tickID = value; }
        }
        #endregion

        #region [Constructors]
        public void CustTicks()
        {

        }
        #endregion
    }
}
