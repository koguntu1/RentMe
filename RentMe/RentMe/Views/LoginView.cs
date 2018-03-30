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
    public partial class LoginView : Form
    { 
            public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MenuView menuForm = new MenuView();
            if (menuForm.Enabled)
            {
                

                if (menuForm.IsDisposed)
                {
                    menuForm = new MenuView();
                    menuForm.StartPosition = FormStartPosition.CenterScreen;
                    menuForm.Show();
                    this.Close();
                }
                else
                {
                    menuForm.StartPosition = FormStartPosition.CenterScreen;
                    menuForm.Show();
                    
                }
                this.Hide();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(1);
        }

        private void LoginView_FormClosed(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
