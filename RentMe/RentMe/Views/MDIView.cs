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
    public partial class MDIView : Form
    {
        CustomerView customer = new CustomerView();
        FurnitureView furniture = new FurnitureView();
        ChangePasswordView password = new ChangePasswordView();
        LoginView loginForm = new LoginView();
        EmployeeView employee = new EmployeeView();
        public MDIView()
        {
            InitializeComponent();
        }

        private void MDIView_Load(object sender, EventArgs e)
        {
            if (loginForm.Enabled)
            {


                if (loginForm.IsDisposed)
                {
                    loginForm = new LoginView();
                    loginForm.MdiParent = this;
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.Show();
                }
                else
                {
                    loginForm.MdiParent = this;
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.Show();

                }
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (customer.Enabled)
            {

                if (customer.IsDisposed)
                {
                    customer = new CustomerView();
                    customer.MdiParent = this;
                    //customer.StartPosition = FormStartPosition.CenterScreen;
                    customer.Show();
                }
                else
                {
                    customer.MdiParent = this;
                    //customer.StartPosition = FormStartPosition.CenterScreen;
                    customer.Show();
                }
            }
        }

        private void furnitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (furniture.Enabled)
            {


                if (furniture.IsDisposed)
                {
                    furniture = new FurnitureView();
                    furniture.MdiParent = this;
                    //furniture.StartPosition = FormStartPosition.CenterScreen;
                    furniture.Show();
                }
                else
                {
                    furniture.MdiParent = this;
                    //furniture.StartPosition = FormStartPosition.CenterScreen;
                    furniture.Show();
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (password.Enabled)
            {


                if (password.IsDisposed)
                {
                    password = new ChangePasswordView();
                    password.MdiParent = this;
                    //password.StartPosition = FormStartPosition.CenterScreen;
                    password.Show();
                }
                else
                {
                    password.MdiParent = this;
                    //password.StartPosition = FormStartPosition.CenterScreen;
                    password.Show();
                }
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {

        }

        private void addUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee.Enabled)
            {


                if (employee.IsDisposed)
                {
                    employee = new EmployeeView();
                    employee.MdiParent = this;
                    //employee.StartPosition = FormStartPosition.CenterScreen;
                    employee.Show();
                }
                else
                {
                    employee.MdiParent = this;
                    //employee.StartPosition = FormStartPosition.CenterScreen;
                    employee.Show();
                }
            }
        }

        private void txtLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
