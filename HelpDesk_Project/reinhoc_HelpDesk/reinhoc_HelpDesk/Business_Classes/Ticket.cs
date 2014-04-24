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
    /// A Help Desk Ticket
    /// </summary>
    public class Ticket
    {
        #region [Private Fields]
        private int _tickID;
        private string _problemTitle;
        private string _problemDescription;
        private int _severity;
        private bool _completed;
        private string _fixDescription;
        #endregion

        #region [Public Properties]
        /// <summary>
        /// Ticket ID
        /// </summary>
        public int TickID
        {
            get { return _tickID; }
            set { _tickID = value; }
        }
        /// <summary>
        /// Title of the ticket
        /// </summary>
        public string ProblemTitle
        {
            get { return _problemTitle; }
            set { _problemTitle = value; }
        }
        /// <summary>
        /// Description of the problem
        /// </summary>
        public string ProblemDescription
        {
            get { return _problemDescription; }
            set { _problemDescription = value; }
        }
        /// <summary>
        /// How important is it?
        /// </summary>
        public int Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }
        /// <summary>
        /// Is it completed?
        /// </summary>
        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }           
        }
        /// <summary>
        /// How was it fixed?
        /// </summary>
        public string FixDescription
        {
            get { return _fixDescription; }
            set { _fixDescription = value; }
        }
        #endregion

        #region [Constructors]
        /// <summary>
        /// Default Ticket
        /// </summary>
        public void Tickets()
        {

        }
        #endregion
    }
}
