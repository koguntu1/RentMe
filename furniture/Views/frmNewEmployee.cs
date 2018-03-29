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
    public partial class frmNewEmployee : Form
    {
        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void LblCustID_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtCustID.Text.Length == 0 || TxtFname.Text.Length == 0 || TxtLname.Text.Length == 0 || TxtSex.Text.Length == 0 || TxtDoB.Text.Length == 0 || TxtAddress.Text.Length == 0 || TxtPhone.Text.Length == 0 || TxtSSN.Text.Length == 0)
            {
                MessageBox.Show("Please provide all information required !");
            }
            else
            {
                if(new DB_Access().addEmployee(TxtCustID.Text, TxtFname.Text, TxtLname.Text, TxtSex.Text, TxtDoB.Text, TxtAddress.Text, TxtPhone.Text, TxtSSN.Text))
                MessageBox.Show("Employee Successfully added");
                TxtCustID.Text = "";
                TxtFname.Text = "";
                TxtLname.Text = "";
                TxtSex.Text = "";
                TxtDoB.Text = "";
                TxtAddress.Text = "";
                TxtPhone.Text = "";
                TxtSSN.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmAdminControl().Visible = true;
        }
    }
}
