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
                        loginScreen.StartPosition = FormStartPosition.CenterScreen;
                        loginScreen.Show();
                    }
                    else
                    {
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
                    customer.StartPosition = FormStartPosition.CenterScreen;
                    customer.Show();
                }
                else
                {
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
                    furniture.StartPosition = FormStartPosition.CenterScreen;
                    furniture.Show();
                }
                else
                {
                    furniture.StartPosition = FormStartPosition.CenterScreen;
                    furniture.Show();
                }
                this.Hide();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (loginScreen.Enabled)
            {

                if (loginScreen.IsDisposed)
                {
                    loginScreen = new LoginView();
                    loginScreen.StartPosition = FormStartPosition.CenterScreen;
                    loginScreen.Show();
                }
                else
                {
                    loginScreen.StartPosition = FormStartPosition.CenterScreen;
                    loginScreen.Show();
                }
            }

            this.Close();
        }
    }
}
