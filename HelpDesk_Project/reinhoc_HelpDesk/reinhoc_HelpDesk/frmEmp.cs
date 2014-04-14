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
    public partial class frmEmp : Form
    {
        public frmEmp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HelpFacade help = new HelpFacade();
            string first = txtFirstName.Text.ToString();
            string last = txtLastName.Text.ToString();
            string userName = txtUserName.Text.ToString();
            help.AddEmployee(first, last, userName);
        }
    }
}
