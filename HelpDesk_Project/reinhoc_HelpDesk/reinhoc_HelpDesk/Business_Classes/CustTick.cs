using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinhoc_HelpDesk.Business_Classes
{
    class CustTick
    {
            #region [Private Fields]
            private int _custID;
            private int _tickID;
            private string _fixDescription;
            #endregion
 
            #region [Public Properties]
            public int CustID
            {
                        get { return _custID; }
                        set { _custID = value; }
            }
 
            public int TickID
            {
                        get { return _tickID; }
                        set { _tickID = value; }
            }
 
            public string FixDescription
            {
                        get { return _fixDescription; }
                        set { _fixDescription = value; }
            }
            #endregion
 
            #region [Constructors]
            public void CustTicks()
            {
 
            }
            #endregion
    }
}
