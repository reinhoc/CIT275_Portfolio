using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinhoc_HelpDesk.Business_Classes
{
    class Ticket
    {
        #region [Private Fields]
        private int _tickID;
        private string _problemTitle;
        private string _problemDescription;
        private int _severity;
        private bool _completed;
        #endregion

        #region [Public Properties]
        public int TickID
        {
            get { return _tickID; }
            set { _tickID = value; }
        }

        public string ProblemTitle
        {
            get { return _problemTitle; }
            set { _problemTitle = value; }
        }

        public string ProblemDescription
        {
            get { return _problemDescription; }
            set { _problemDescription = value; }
        }

        public int Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        #endregion

        #region [Constructors]
        public void Tickets()
        {

        }
        #endregion
    }
}
