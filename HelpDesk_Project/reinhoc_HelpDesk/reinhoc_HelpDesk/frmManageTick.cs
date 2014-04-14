using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reinhoc_HelpDesk.Facade;

namespace reinhoc_HelpDesk
{
    public partial class frmManageTick : Form
    {
        HelpFacade help = new HelpFacade();
        public frmManageTick()
        {
            InitializeComponent();
            PopulateAll();
        }
        private void cboSearchTicket_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cboCustomer.Items.Clear();
            //Gets the ticket.
            int tick = Int32.Parse(cboSearchTicket.Text);
            var superTick = help.GetTicket(tick);
            //Searchs for customer ID by ticket
            int custTick = help.SearchForCust(tick);
            //Searches for Customer Name by ID.
            if (custTick >= 1)
            {
                var custName = help.GetCustomerByID(custTick);
                cboCustomer.Text = custName.Item2.ToString();
            }
            else
            {
                cboCustomer.Text = "";
            }
            ////Searches for employee ID by ticket
            //int empTick = help.SearchForEmp(tick);
            //if (empTick >= 1)
            //{
            //    var empUName = 
            //}
            txtTickNum.Text = superTick.Item1.ToString();            
            txtTickTitle.Text = superTick.Item2.ToString();
            txtTickDescription.Text = superTick.Item3.ToString();
            numSeverity.Value = superTick.Item4;
            ckbTickComplete.Checked = superTick.Item5;
            txtFixDescription.Text = superTick.Item6.ToString();
        }

        private void cboSearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> custTicks = new List<int>();
            string name = cboSearchCustomer.Text;
            var cust = help.GetCustomer(name);
            custTicks = help.SearchCustTicks(cust.Item1);
            cboSearchTicket.Items.Clear();
            foreach (int tick in custTicks)
            {
                cboSearchTicket.Items.Add(tick);
            }
        }
        private void cboSearchEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> empTicks = new List<int>();
            string user = cboSearchEmp.Text;
            var emp = help.GetEmployee(user);
            empTicks = help.SearchEmpTicks(emp.Item1);
            cboSearchTicket.Items.Clear();
            foreach (var tick in empTicks)
            {
                cboSearchTicket.Items.Add(tick);
            }
        }
        private void PopulateAll()
        {
            cboSearchTicket.Items.Clear();
            cboSearchEmp.Items.Clear();
            cboSearchCustomer.Items.Clear();
            cboCustomer.Items.Clear();
            cboUserName.Items.Clear();
            //Populates the ticket combo box
            List<int> tickets = new List<int>();
            tickets = help.GetTickets();
            foreach (int tick in tickets)
            {
                cboSearchTicket.Items.Add(tick);
            }
            //Populates the customer combo boxes.
            List<string> customers = new List<string>();
            customers = help.GetCustomers();
            foreach (string custs in customers)
            {
                cboSearchCustomer.Items.Add(custs);
                cboCustomer.Items.Add(custs);
            }
            //Populates the employee combo boxes
            List<string> employees = new List<string>();
            employees = help.GetEmployees();
            foreach (string emp in employees)
            {
                cboSearchEmp.Items.Add(emp);
                cboUserName.Items.Add(emp);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateAll();
        }


    }
}
