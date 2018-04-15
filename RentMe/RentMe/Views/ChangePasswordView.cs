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
    public partial class ChangePasswordView : Form
    {
        String userID;
        //MenuView menuScreen = new MenuView();
        private LoginController lgCont;
        public ChangePasswordView()
        {
            InitializeComponent();
            lgCont = new LoginController();
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {
            Form frm = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            ToolStripMenuItem lt = (ToolStripMenuItem)ms.Items["login"];
            userID = lt.Text;
            this.lblLoggedIn.Text = userID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (mtxtCurrentPassword.Text == "")

            {

                MessageBox.Show("Please enter a current password!");

                mtxtCurrentPassword.Focus();

            }

            else if (mtxtNewPassword.Text == "")

            {

                MessageBox.Show("Please enter a valid password!");

                mtxtNewPassword.Focus();

            }
            else if (!mtxtNewPassword.Text.Equals(mtxtConfirmPassword.Text))
            {

                MessageBox.Show("New password and confirm password do not match.");
                mtxtNewPassword.Focus();
                mtxtConfirmPassword.Focus();
            }

            else if (mtxtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please confirm new password");

                mtxtConfirmPassword.Focus();
            }

            if (mtxtCurrentPassword.Text != "" && mtxtNewPassword.Text != "" && mtxtConfirmPassword.Text != "" && mtxtNewPassword.Text.Equals(mtxtConfirmPassword.Text))
            {

                try
                {
                    if (lgCont.GetLoginPassword(this.userID) == mtxtCurrentPassword.Text)
                    {
                        if (lgCont.SetLoginPassword(this.userID, mtxtCurrentPassword.Text, mtxtNewPassword.Text))
                        {
                            MessageBox.Show("Password updated!");
                        }
                        else
                        {
                            MessageBox.Show("Error: password not updated");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password does not match.");
                        mtxtNewPassword.Focus();
                        mtxtCurrentPassword.Focus();
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
