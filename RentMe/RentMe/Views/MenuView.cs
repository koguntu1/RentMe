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
        CustomerView customerView = new CustomerView();
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
            if (customerView.Enabled)
            {

                if (customerView.IsDisposed)
                {
                    customerView = new CustomerView();
                    customerView.StartPosition = FormStartPosition.CenterScreen;
                    customerView.Show();
                }
                else
                {
                    customerView.StartPosition = FormStartPosition.CenterScreen;
                    customerView.Show();
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
    }
}
