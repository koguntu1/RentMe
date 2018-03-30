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

        MenuView menuForm = new MenuView();

            public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
            }
            
        }
    }
}
