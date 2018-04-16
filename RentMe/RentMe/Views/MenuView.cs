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
    public partial class MenuView : Form
    {

        LoginView loginScreen = new LoginView();


        public MenuView()
        {
            InitializeComponent();


        }

        private void MenuView_Load(object sender, EventArgs e)
        {

            // Add corrected code for user that is logged into system
            //lblUser.Text = fname + " " + middleinitial + ". " + lname;
        }

        private void MenuView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }
            else
            {

                
                if (loginScreen.Enabled)
                {

                    if (loginScreen.IsDisposed)
                    {
                        loginScreen = new LoginView();
                        loginScreen.MdiParent = this.MdiParent;
                        loginScreen.StartPosition = FormStartPosition.CenterScreen;
                        loginScreen.Show();
                    }
                    else
                    {
                        loginScreen.MdiParent = this.MdiParent;
                        loginScreen.StartPosition = FormStartPosition.CenterScreen;
                        loginScreen.Show();
                    }
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerView customer = new CustomerView();
            
            if (customer.Enabled)
            {

                if (customer.IsDisposed)
                {
                    customer = new CustomerView();
                    customer.MdiParent = this.MdiParent;
                    customer.StartPosition = FormStartPosition.CenterScreen;
                    customer.Show();
                }
                else
                {
                    customer.MdiParent = this.MdiParent;
                    customer.StartPosition = FormStartPosition.CenterScreen;
                    customer.Show();
                }

                this.Hide();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFurniture_Click(object sender, EventArgs e)
        {
            FurnitureView furniture = new FurnitureView();
            if (furniture.Enabled)
            {


                if (furniture.IsDisposed)
                {
                    furniture = new FurnitureView();
                    furniture.MdiParent = this.MdiParent;
                    furniture.StartPosition = FormStartPosition.CenterScreen;
                    furniture.Show();
                }
                else
                {
                    furniture.MdiParent = this.MdiParent;
                    furniture.StartPosition = FormStartPosition.CenterScreen;
                    furniture.Show();
                }
                this.Hide();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordView password = new ChangePasswordView();
            if (password.Enabled)
            {


                if (password.IsDisposed)
                {
                    password = new ChangePasswordView();
                    password.MdiParent = this.MdiParent;
                    password.StartPosition = FormStartPosition.CenterScreen;
                    password.Show();
                }
                else
                {
                    password.MdiParent = this.MdiParent;
                    password.StartPosition = FormStartPosition.CenterScreen;
                    password.Show();
                }
                this.Hide();
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            AddUpdateEmployeeView employee = new AddUpdateEmployeeView();
            if (employee.Enabled)
            {


                if (employee.IsDisposed)
                {
                    employee = new AddUpdateEmployeeView();
                    employee.MdiParent = this.MdiParent;
                    employee.StartPosition = FormStartPosition.CenterScreen;
                    employee.Show();
                }
                else
                {
                    employee.MdiParent = this.MdiParent;
                    employee.StartPosition = FormStartPosition.CenterScreen;
                    employee.Show();
                }
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (loginScreen.Enabled)
            {

                if (loginScreen.IsDisposed)
                {
                    loginScreen = new LoginView();
                    loginScreen.MdiParent = this.MdiParent;
                    loginScreen.StartPosition = FormStartPosition.CenterScreen;
                    loginScreen.Show();
                }
                else
                {
                    loginScreen.MdiParent = this.MdiParent;
                    loginScreen.StartPosition = FormStartPosition.CenterScreen;
                    loginScreen.Show();
                }
            }

            this.Close();
        }
    }
}
