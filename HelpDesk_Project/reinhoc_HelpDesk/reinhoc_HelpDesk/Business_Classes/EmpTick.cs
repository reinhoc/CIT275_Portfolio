using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinhoc_HelpDesk.Business_Classes
{
    class EmpTick
    {
        #region [Private Fields]
        private int _empID;
        private int _tickID;
   
        #endregion

        #region [Public Properties]
        public int EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public int TickID
        {
            get { return _tickID; }
            set { _tickID = value; }
        }
        #endregion

        #region [Constructors]
        public void EmpTicks()
        {

        }
        #endregion
    }
}