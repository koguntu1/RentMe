using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;

namespace RentMe.Views
{


    public partial class LoginView : Form
    {
        private LoginController lgCont;
        public LoginView()
        {

            InitializeComponent();
            lgCont = new LoginController();

        }

        private void disableControls()
        {

        }

        private void enableControls()
        {
            Form frm = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            ToolStripMenuItem lt = (ToolStripMenuItem)ms.Items["login"];
            lt.Visible = true;
            lt.Text = txtLogin.Text;



            ToolStripMenuItem mt = (ToolStripMenuItem)ms.Items["maintenanceToolStripMenuItem"];
            mt.Enabled = true;
            ToolStripMenuItem et = (ToolStripMenuItem)ms.Items["employeeToolStripMenuItem"];
            et.Enabled = true;
            ToolStripMenuItem rt = (ToolStripMenuItem)ms.Items["adminReportsToolStripMenuItem"];
            try
            {
                if (lgCont.IsAdminRole(txtLogin.Text, textBox2.Text))
                {
                    et.DropDownItems["addUpdateEmployeeToolStripMenuItem"].Enabled = true;
                    et.DropDownItems["addUpdateEmployeeToolStripMenuItem"].Visible = true;
                    rt.Enabled = true;
                    rt.Visible = true;
                }
                else
                {
                    et.DropDownItems["addUpdateEmployeeToolStripMenuItem"].Enabled = false;
                    et.DropDownItems["addUpdateEmployeeToolStripMenuItem"].Visible = false;
                    rt.Enabled = false;
                    rt.Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginUser();
            }
        }

        private void LoginUser()
        {
            if (txtLogin.Text == "")

            {

                MessageBox.Show("Please enter a valid user name!");

                txtLogin.Focus();

            }

            else if (textBox2.Text == "")

            {

                MessageBox.Show("Please enter a valid password!");

                textBox2.Focus();

            }
            if ((txtLogin.Text != "" && textBox2.Text != ""))
            {

                try
                {
                    if (true)//lgCont.isValidLogin(txtLogin.Text, textBox2.Text))
                    {
                        this.enableControls();



                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username and/or password.");
                        txtLogin.Focus();
                        textBox2.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
