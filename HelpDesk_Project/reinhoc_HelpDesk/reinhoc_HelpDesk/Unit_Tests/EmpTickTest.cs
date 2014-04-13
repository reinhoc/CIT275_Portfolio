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
    public class EmpTickTest
    {
        EmpTickRepo empTickRepo = new EmpTickRepo();
        EmpTick empTick = new EmpTick();

        [TestMethod]
        public void AddEmpTickTest()
        {

            empTick.EmpID = 1;
            empTick.TickID = 2;
            empTickRepo.InsertEmpTick(empTick);
        }
        //[TestMethod]
        //public void GetEmpTicksTest()
        //{
        //    var test = empTickRepo.GetEmpTicks();
        //    Assert.AreEqual(2, test.Count());
        //}

        //[TestMethod]
        //public void GetEmpTickTest()
        //{
        //    empTick.EmpID = 1;
        //    empTick.TickID = 1;
        //    var empTTest = empTickRepo.GetEmpTick(empTick);
        //    Assert.IsNotNull(empTTest);
        //}
    }
}
