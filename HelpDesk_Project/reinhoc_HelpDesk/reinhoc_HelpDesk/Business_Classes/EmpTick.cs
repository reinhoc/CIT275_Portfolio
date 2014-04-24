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
    /// A joining of Employees and Tickets
    /// </summary>
    public class EmpTick
    {
        #region [Private Fields]
        private int _empID;
        private int _tickID;
   
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
        /// Ticket ID
        /// </summary>
        public int TickID
        {
            get { return _tickID; }
            set { _tickID = value; }
        }
        #endregion

        #region [Constructors]
        /// <summary>
        /// Default EmpTicks
        /// </summary>
        public void EmpTicks()
        {

        }
        #endregion
    }
}