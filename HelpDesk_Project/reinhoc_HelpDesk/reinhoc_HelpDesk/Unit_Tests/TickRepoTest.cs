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
    public class TickRepoTest
    {
        TicketRepo ticketRepo = new TicketRepo();
        Ticket ticket = new Ticket();

        [TestMethod]
        public void AddTicketTest()
        {
            ticket.ProblemTitle = "Cannot debug unit test";
            ticket.ProblemDescription = "Having issues using debug within coding window.";
            ticket.Severity = 1;
            ticket.Completed = true;
            ticketRepo.InsertTicket(ticket);
        }

        [TestMethod]
        public void UpdateTicketTest()
        {
            ticket.TickID = 1;
            ticket.ProblemTitle = "Having issues debugging in testing.";
            ticket.ProblemDescription = "Having issues using debug within coding window.";
            ticket.Severity = 1;
            ticket.Completed = true;
            ticketRepo.UpdateTicket(ticket);
        }

        [TestMethod]
        public void GetTicketsTest()
        {
            var test = ticketRepo.GetTickets();
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void GetTicketTest()
        {
            ticket.TickID = 1;
            var tickTest = ticketRepo.GetTicket(ticket);
            Assert.AreEqual(true, tickTest.Completed);
        }
    }
}
