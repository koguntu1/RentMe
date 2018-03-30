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
    public partial class CustomerView : Form
    {

        MenuView menuScreen = new MenuView();
        public CustomerView()
        {
            InitializeComponent();


        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.rentMeDataSet.Employee);
            // TODO: This line of code loads data into the 'rentMeDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.rentMeDataSet.Gender);
            lblStateInfo.Text = "";
            // TODO: This line of code loads data into the 'rentMeDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            // TODO: This line of code loads data into the 'rentMeDataSet.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.rentMeDataSet.Streets);
            cboState.SelectedIndex = -1;
            cboStreetType.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            DisableControls();
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            mtxtHomePhone.Enabled = true;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnExit.Enabled = true;


            // Add corrected code for user that is logged into system
            //lblUser.Text = fname + " " + middleinitial + ". " + lname;

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayState();
        }

        private void displayState()
        {

            if (cboState.SelectedIndex == -1)
            {
                lblStateInfo.Text = "";
            }
            else
            {
                DataRowView drv = (DataRowView)cboState.SelectedItem;
                string stateName = drv["name"].ToString() + ", " + drv["country"].ToString();

                if (stateName != null)
                {
                    lblStateInfo.Text = stateName;
                }
                else
                {
                    lblStateInfo.Text = "";
                }
            }

        }

        private void displayStreet()
        {
            if (cboStreetType.SelectedIndex == -1)
            {
                lblStreetInfo.Text = "";
            }
            else
            {
                DataRowView drv = (DataRowView)cboStreetType.SelectedItem;
                string streetType = drv["name"].ToString();

                if (streetType != null)
                {
                    lblStreetInfo.Text = streetType;
                }
                else
                {
                    lblStreetInfo.Text = "";
                }
            }
        }

        private void cboStreetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStreet();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGender();
        }

        private void displayGender()
        {

            if (cboGender.SelectedIndex == -1)
            {
                cboGender.Text = "";
            }
            else
            {
                DataRowView drv = (DataRowView)cboGender.SelectedItem;
                string genderType = drv["description"].ToString();

                if (genderType != null)
                {
                    lblGender.Text = genderType;
                }
                else
                {
                    lblGender.Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisableControls();
            btnAdd.Enabled = true;
            btnExit.Enabled = true;
            btnSearch.Enabled = true;
            btnRestart.Enabled = true;
            btnAdd.Text = "Update";
            btnSearch.Text = "Search Again";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuScreen.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnRestart.Enabled = true;
        }

        private void EnableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = true;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = true;
                }
            }
        }

        private void DisableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = false;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = false;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DisableControls();
            txtFirstName.Enabled = true;
            txtFirstName.Text = "";
            txtLastName.Enabled = true;
            txtLastName.Text = "";
            mtxtHomePhone.Enabled = true;
            mtxtHomePhone.Text = "";
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnAdd.Text = "Add";
            btnExit.Enabled = true;
        }

        private void CustomerView_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
