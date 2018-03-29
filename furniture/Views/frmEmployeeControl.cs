using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture.Views
{
    public partial class frmEmployeeControl : Form
    {
        private string user = "";
        public frmEmployeeControl(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmNewCustomer(2).Visible = true;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Furniture().Visible = true;
        }

        private void add_customer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword();
            frmChange.Show();
            //if(txtNewPass1.Text.Trim() == txtNewPass2.Text.Trim())
            //{
            //    //call update pass
            //    if(new DB_Access().updateLogin(user,txtNewPass1.Text))
            //    {
            //        MessageBox.Show("The password have been updated","Successfull Update");
            //    }
            //    else
            //    {
            //        MessageBox.Show("The password cannot updated", "Fail Update");
            //    }
            //    txtNewPass1.Clear();
            //    txtNewPass2.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("Password not match in two time write. Please try again", "Invalid Password");
            //}
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new seach_customer().Visible = true;
        }
    }
}
