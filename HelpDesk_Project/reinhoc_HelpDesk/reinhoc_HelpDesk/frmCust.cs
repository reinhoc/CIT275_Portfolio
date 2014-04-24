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
    public partial class frmCust : Form
    {
        public frmCust()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HelpFacade help = new HelpFacade();
            string name = txtCustName.Text.ToString();
            string address = txtCustAddress.Text.ToString();
            string state = txtCustState.Text.ToString();
            int zip = int.Parse(txtCustZip.Text);
            help.AddCustomer(name, address, state, zip);
        }
    }
}
