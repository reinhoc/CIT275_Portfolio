using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using reinhoc_HelpDesk.Repositories;
using reinhoc_HelpDesk.Business_Classes;

namespace reinhoc_HelpDesk.Unit_Tests
{
    [TestClass]
    public class CustTickRepoTest
    {
        CustTickRepo custTRepo = new CustTickRepo();
        CustTick custT = new CustTick();

        [TestMethod]
        public void AddCustomerTest()
        {

            custT.CustID = 1;
            custT.TickID = 1002;     
            custTRepo.InsertCustTick(custT);
        }
        [TestMethod]
        public void SearchCustomersTest()
        {
            custT.CustID = 1;
            var test = custTRepo.SearchCustTicks(custT);
            Assert.IsNotNull(test);
        }
    }
}
