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
    public class EmployeeRepoTest
    {
        EmployeeRepo empRepo = new EmployeeRepo();
        Employee emp = new Employee();

        [TestMethod]
        public void AddEmployeeTest()
        {

            emp.EmpFName = "Test";
            emp.EmpLName = "Employee";
            emp.EmpUName = "temp";
            empRepo.InsertEmployee(emp);
        }

        [TestMethod]
        public void UpdateEmployeeTest()
        {
            emp.EmpID = 1;
            emp.EmpFName = "Update";
            emp.EmpLName = "Test";
            emp.EmpUName = "UpTest";
            empRepo.UpdateEmployee(emp);
        }

        [TestMethod]
        public void GetEmployeesTest()
        {
            var test = empRepo.GetEmployees();
            Assert.AreEqual(5, test.Count());
        }

        [TestMethod]
        public void GetEmployeeTest()
        {
            emp.EmpID = 1;
            var empTest = empRepo.GetEmployee(emp);
            Assert.AreEqual("Update", empTest.EmpFName.ToString());
        }
    }
}
