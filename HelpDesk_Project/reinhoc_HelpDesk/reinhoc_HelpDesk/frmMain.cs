using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reinhoc_HelpDesk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            frmCust frc = new frmCust();
            frc.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmp fre = new frmEmp();
            fre.ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            frmManageTick frM = new frmManageTick();
            frM.ShowDialog();
        }
    }
}
