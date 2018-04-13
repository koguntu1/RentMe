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
        LoginController loginController;
        Employee employee;
        public EmployeeView()
        {
            InitializeComponent();
            inController = new EmployeeController();
            loginController = new LoginController();
            employee = null;
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.rentMeDataSet.Login);
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
            txtPassword.Visible = false;
            lblPassword.Visible = false;
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

                    DisplayEmployee(employee);

                    DisableControls();
                    btnAdd.Enabled = true;
                    btnExit.Enabled = true;
                    btnSearch.Enabled = true;
                    btnRestart.Enabled = true;
                    btnChangePassword.Enabled = true;
                    txtPassword.Visible = false;
                    lblPassword.Visible = false;
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



        private void DisplayEmployee(Employee employee)
        {
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
            txtUserID.Text = employee.login.ToString();
        }

        private void PutEmployee(Employee employee)
        {
            employee.fname = txtFname.Text;
            employee.fname = txtFname.Text;
            employee.middleInitial = txtMI.Text;
            employee.lname = txtLname.Text;
            employee.Address1 = txtAddress1.Text;
            employee.Address2 = txtAddress2.Text;
            employee.City = txtCity.Text;
            employee.State = cboState.SelectedValue.ToString();
            mtxtZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            employee.PostalCode = mtxtZip.Text;
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            employee.homePhone = mtxtHomePhone.Text;
            employee.dateOfBirth = tpBirthDate.Value;
            employee.gender = cboGender.SelectedValue.ToString();
            employee.admin = cboAdmin.Text;
            employee.login = txtUserID.Text;
            employee.password = loginController.EncryptPassword(txtPassword.Text);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableControls();
            if (btnAdd.Text == "Add")
            {
                txtUserID.Enabled = true;
                txtPassword.Visible = true;
                lblPassword.Visible = true;
            }
            else
            {
                txtUserID.Enabled = false;
                txtPassword.Visible = false;
                lblPassword.Visible = false;
            }
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

            lblGender.Text = "";
            lblStateInfo.Text = "";
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
            txtPassword.Visible = false;
            lblPassword.Visible = false;
            ClearFields();
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayState();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGender();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            
            try
            {
                if (btnAdd.Text == "Add")
                {
                    this.PutEmployee(newEmployee);
                    this.inController.AddEmployee(newEmployee);
                    MessageBox.Show("Employee successfully added");
                    DisableControls();
                    btnAdd.Enabled = true;
                    btnAdd.Text = "Update";
                    btnRestart.Enabled = true;
                    btnExit.Enabled = true;
                    txtPassword.Visible = false;
                    lblPassword.Visible = false;
                }

                else if (btnAdd.Text == "Update")
                {
                    this.PutEmployee(newEmployee);
                    newEmployee.employeeID = employee.employeeID;
                    if (!inController.UpdateEmployee(employee, newEmployee))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that employee.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        employee = newEmployee;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Member has been updated.");
                        DisableControls();
                        btnRestart.Enabled = true;
                        btnAdd.Enabled = true;
                        btnExit.Enabled = true;
                        txtPassword.Visible = false;
                        lblPassword.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
 
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (btnChangePassword.Text == "Change Password")
            {
                lblPassword.Visible = true;
                txtPassword.Visible = true;
                txtPassword.Enabled = true;
                btnSearch.Enabled = false;
                btnAdd.Enabled = false;
                btnChangePassword.Text = "Update Password";
            }
            else if (btnChangePassword.Text == "Update Password")
            {
                string password = loginController.EncryptPassword(txtPassword.Text);
                try
                {
                    if (inController.UpdateEmployeePassword(employee, password))
                    {
                        MessageBox.Show("Employee password updated. Please make a note of it.");
                        btnChangePassword.Text = "Change Password";
                        DisableControls();
                        txtFname.Enabled = true;
                        txtLname.Enabled = true;
                        mtxtHomePhone.Enabled = true;
                        btnSearch.Enabled = true;
                        btnAdd.Enabled = true;
                        btnAdd.Text = "Add";
                        btnExit.Enabled = true;
                        txtPassword.Visible = false;
                        lblPassword.Visible = false;
                        ClearFields();

                    }
                    else
                    {
                        MessageBox.Show("Unable to update password.");
                        btnChangePassword.Text = "Change Password";
                        DisableControls();
                        txtFname.Enabled = true;
                        txtLname.Enabled = true;
                        mtxtHomePhone.Enabled = true;
                        btnSearch.Enabled = true;
                        btnAdd.Enabled = true;
                        btnAdd.Text = "Add";
                        btnExit.Enabled = true;
                        txtPassword.Visible = false;
                        lblPassword.Visible = false;
                        ClearFields();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update password.");
                    btnChangePassword.Text = "Change Password";
                    DisableControls();
                    txtFname.Enabled = true;
                    txtLname.Enabled = true;
                    mtxtHomePhone.Enabled = true;
                    btnSearch.Enabled = true;
                    btnAdd.Enabled = true;
                    btnAdd.Text = "Add";
                    btnExit.Enabled = true;
                    txtPassword.Visible = false;
                    lblPassword.Visible = false;
                    ClearFields();
                }
            }
        }
    }
}
