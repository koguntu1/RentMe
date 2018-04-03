using RentMe.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.Views
{
    public partial class ChangePasswordView : Form
    {

        MenuView menuScreen = new MenuView();
        string username = "";
        LoginController loginController;
        public ChangePasswordView(string user)
        {
            InitializeComponent();
            loginController = new LoginController();
            username = user;
            lblLoggedIn.Text = username;
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!loginController.checkCurrentPassword(username, mtxtCurrentPassword.Text))
                {
                    MessageBox.Show("Enter wrong current password. " +
                            "Please try again.", "Incorrect password");
                }
                else
                {
                    if(mtxtNewPassword.Text != mtxtConfirmPassword.Text)
                    {
                        MessageBox.Show("Confirm password not match with new password. " +
                            "Please try again.", "Do not match password");
                    }
                    else
                    {
                        if(loginController.updatePassword(username, mtxtNewPassword.Text))
                        {
                            MessageBox.Show("Update password successfull. ", "Updated password");
                        }
                        else
                        {
                            MessageBox.Show("Update password unsuccessfull. ", "Updated password");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
