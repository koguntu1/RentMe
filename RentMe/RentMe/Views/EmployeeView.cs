using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Models;

namespace RentMe.Views
{
    public partial class EmployeeView : Form
    {
        MenuView menuScreen = new MenuView();
        EmployeeController inController;
        public EmployeeView()
        {
            InitializeComponent();
            inController = new EmployeeController();

        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.rentMeDataSet.Gender);
            // TODO: This line of code loads data into the 'rentMeDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            // TODO: This line of code loads data into the 'rentMeDataSet.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.rentMeDataSet.Streets);
            // TODO: This line of code loads data into the 'rentMeDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.rentMeDataSet.Employee);
            DisableControls();
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnExit.Enabled = true;
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            mtxtHomePhone.Enabled = true;
            cboState.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            cboAdmin.SelectedIndex = -1;

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
            Employee employee = null;
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            btnRestart.Enabled = true;
            try
            {


                if ((!txtFname.Text.Equals("") && !txtLname.Equals("")) || !mtxtHomePhone.Text.Equals("") )
                {
                    if ((!txtFname.Text.Equals("") && !txtLname.Equals("")))
                    {
                        employee = inController.GetEmployeeByName(txtFname.Text.ToString().ToUpper(), txtLname.Text.ToString().ToUpper());
                    }
                    
                    if (!mtxtHomePhone.Text.Equals(""))
                    {
                        employee = inController.GetEmployeeByPhone(mtxtHomePhone.Text);
                    }

                    txtFname.Text = employee.fname.ToString();
                    txtMI.Text = employee.middleInitial.ToString();
                    txtLname.Text = employee.lname.ToString();
                    txtAddress1.Text = employee.Address1.ToString();
                    txtAddress2.Text = employee.Address2.ToString();
                    txtCity.Text = employee.City.ToString();
                    cboState.SelectedValue = employee.State.ToString();
                    mtxtZip.Text = employee.PostalCode.ToString();
                    mtxtHomePhone.Text = employee.homePhone.ToString();
                    tpBirthDate.Text = employee.dateOfBirth.ToString();
                    cboGender.SelectedValue = employee.gender.ToString();
                    cboAdmin.Text = employee.admin.ToString();

                    DisableControls();
                    btnAdd.Enabled = true;
                    btnExit.Enabled = true;
                    btnSearch.Enabled = true;
                    btnRestart.Enabled = true;
                    btnAdd.Text = "Update";
                    btnSearch.Text = "Search Again";
                }
                else
                {
                    MessageBox.Show("You must enter a name or phone number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No results found. Please try again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = true;
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

                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = false;
                }
            }
        }

        private void ClearFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Text = "";
                }

                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Text = "";
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DisableControls();
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            mtxtHomePhone.Enabled = true;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnAdd.Text = "Add";
            btnExit.Enabled = true;
            ClearFields();
        }

        //private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.employeeBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.rentMeDataSet);

        //}

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayState();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGender();
        }
    }
}
