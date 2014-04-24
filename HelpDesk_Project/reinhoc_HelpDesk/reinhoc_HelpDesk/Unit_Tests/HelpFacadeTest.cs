using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using reinhoc_HelpDesk.Facade;

namespace reinhoc_HelpDesk.Unit_Tests
{
    [TestClass]
    public class HelpFacadeTest
    {
        HelpFacade Help = new HelpFacade();

        #region[Customer Method Tests]
        [TestMethod]
        public void AddCustomerTest()
        {
            string name = "Ethan Programming";
            string address = "504 Who Cares Rd";
            string state = "Michigan";
            int zip = 49646;
            Help.AddCustomer(name, address, state, zip);
        }
        [TestMethod]
        public void GetCustomersTest()
        {
            var test = Help.GetCustomers();
            Assert.IsNotNull(test);

        }
        [TestMethod]
        public void GetCustomerTest()
        {
            GetCustomersTest();
            string name = "Ethan Programming";
            var test = Help.GetCustomer(name);
            Assert.IsNotNull(test);
        }
        #endregion
        #region[Employee Method Tests]
        [TestMethod]
        public void AddEmployeeTest()
        {
            string first = "Ethan";
            string last = "Burlison";
            string username = "eburl";
            Help.AddEmployee(first, last, username);
        }
        [TestMethod]
        public void GetEmployeesTest()
        {
            var test = Help.GetEmployees();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void GetEmployeeTest()
        {
            GetEmployeesTest();
            string uName = "eburl";
            var test = Help.GetEmployee(uName);
            Assert.AreEqual("Ethan", test.Item2);
        }
        #endregion
        #region[Ticket Method Tests]
        [TestMethod]
        public void AddTicketTest()
        {
            string pT = "No Longer Updates";
            string pD = "Stupid computer quit updating";
            int tS = 5;
            bool tC = false;
            string tFD = "";
            Help.AddTicket(pT, pD, tS, tC, tFD);
        }
        [TestMethod]
        public void UpdateTicketTest()
        {
            int ID = 1008;
            string pT = "The computer is not updating anymore";
            string pD = "OS XP quit updating.";
            int tS = 5;
            bool tC = true;
            string tFD = "Microsoft is no longer supporting XP";
            Help.UpdateTicket(ID, pT, pD, tS, tC, tFD);
        }
        [TestMethod]
        public void GetTicketsTest()
        {
            var test = Help.GetTickets();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void GetTicketTest()
        {
            GetTicketsTest();
            int ID = 1008;
            var test = Help.GetTicket(ID);
            Assert.AreEqual(true, test.Item5);
        }
        #endregion
        #region[CustTick Method Tests]
        [TestMethod]
        public void AddCustTickTest()
        {
            int cust = 1008;
            int tick = 1008;
            Help.AddCustTick(cust, tick);
        }
        [TestMethod]
        public void SearchCustTicksTest()
        {
            int cust = 1008;
            var test = Help.SearchCustTicks(cust);
            Assert.IsNotNull(test);
        }
        #endregion
        #region[EmpTick Method Tests]
        [TestMethod]
        public void AddEmpTickTest()
        {
            int emp = 1007;
            int tick = 1008;
            Help.AddEmpTick(emp, tick);            
        }
        [TestMethod]
        public void SearchEmpTicksTest()
        {
            int emp = 1007;
            var test = Help.SearchEmpTicks(emp);
            Assert.IsNotNull(test);
        }
        #endregion
    }
}
