using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class frmAdminControl : Form
    {
        public frmAdminControl()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmNewCustomer(2).Visible = true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmNewEmployee().Visible = true;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Furniture().Visible = true;
        }

        private void add_customer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new seach_customer().Visible = true;
        }
    }
}
