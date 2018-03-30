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
        CustomerView customer = new CustomerView();
        //LoginView login = new LoginView();
        public MenuView()
        {
            InitializeComponent();
            
        }

        private void MenuView_Load(object sender, EventArgs e)
        {
            // Add corrected code for user that is logged into system
            //lblUser.Text = fname + " " + middleinitial + ". " + lname;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFurniture_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //if (login.Enabled)
            //{

            //    if (login.IsDisposed)
            //    {
            //        login = new LoginView();
            //        login.StartPosition = FormStartPosition.CenterScreen;
            //        login.Show();
            //    }
            //    else
            //    {
            //        login.StartPosition = FormStartPosition.CenterScreen;
            //        login.Show();
            //    }
            //}

            this.Close();
        }
    }
}
