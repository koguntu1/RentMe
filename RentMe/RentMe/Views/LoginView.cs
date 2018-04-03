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
            try
            {
                if (lgCont.IsAdminRole(txtLogin.Text, textBox2.Text))
                {
                    et.DropDownItems["addUpdateEmployeeToolStripMenuItem"].Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();

        }
    }
}
