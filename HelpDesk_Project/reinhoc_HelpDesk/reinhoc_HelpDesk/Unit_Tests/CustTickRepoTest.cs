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
            custT.TickID = 1;
            custT.FixDescription = "Add public to the beginning of your class";            
            custTRepo.InsertCustTick(custT);
        }

        [TestMethod]
        public void UpdateCustomerTest()
        {
            custT.CustID = 1;
            custT.TickID = 1;
            custT.FixDescription = "Add public to the beginning of your class then use [TestClass] above that.";
            custTRepo.UpdateCustTick(custT);
        }

        [TestMethod]
        public void GetCustomersTest()
        {
            var test = custTRepo.GetCustTicks();
            Assert.AreEqual(1, test.Count());
        }

        [TestMethod]
        public void GetCustomerTest()
        {
            custT.CustID = 1;
            custT.TickID = 1;
            var custTTest = custTRepo.GetCustTick(custT);
            Assert.AreEqual("Add public to the beginning of your class then use [TestClass] above that.", custTTest.FixDescription);
        }
    }
}
