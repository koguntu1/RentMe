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
        public ChangePasswordView()
        {
            InitializeComponent();
        }

        private void ChangePasswordView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }
            else
            {


                if (menuScreen.Enabled)
                {

                    if (menuScreen.IsDisposed)
                    {
                        menuScreen = new MenuView();
                        menuScreen.StartPosition = FormStartPosition.CenterScreen;
                        menuScreen.Show();
                    }
                    else
                    {
                        menuScreen.StartPosition = FormStartPosition.CenterScreen;
                        menuScreen.Show();
                    }
                }
            }
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuScreen.Show();
        }
    }
}
