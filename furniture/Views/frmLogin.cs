using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using furniture.Views;

namespace furniture
{
    public partial class Furniture : Form
    {
        public Furniture()
        {
            InitializeComponent();

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblUername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username.Text=="root" && password.Text=="root")
            {
                this.Visible = false;
                new frmAdminControl().Visible = true;
            }
            else if(new DB_Access().login(username.Text, password.Text))
            {
                this.Visible = false;
                new Views.frmEmployeeControl(username.Text).Visible = true;
                //new seach_customer(new DB_Access().Employee(username.Text, password.Text)).Visible=true;

            }
            else
            {
                MessageBox.Show("Invalid user/password");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword();
            frmChange.Show();
        }
    }
}
