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
    public class CustomerRepoTest
    {
        CustomerRepo custRepo = new CustomerRepo();
        Customer cust = new Customer();

        [TestMethod]
        public void AddCustomerTest()
        {            
            
            cust.CustName = "Test Company";
            cust.CustAddress = "999 Test Ave";
            cust.CustState = "MI";
            cust.CustZip = 49646;
            custRepo.InsertCustomer(cust);
        }
        
        [TestMethod]
        public void UpdateCustomerTest()
        {
            cust.CustID = 9;
            cust.CustName = "Jessica Reinhold";
            cust.CustAddress = "504 N. Cedar St.";
            cust.CustState = "MI";
            cust.CustZip = 49646;
            custRepo.UpdateCustomer(cust);
        }

        [TestMethod]
        public void GetCustomersTest()
        {
            var test = custRepo.GetCustomers();
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void GetCustomerTest()
        {
            cust.CustID = 9;
            var custTest = custRepo.GetCustomer(cust);
            Assert.AreEqual("Jessica Reinhold", custTest.CustName);
        }
    }
}
