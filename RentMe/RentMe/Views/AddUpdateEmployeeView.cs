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
    public partial class AddUpdateEmployeeView : Form
    {
        EmployeeController employeeController;
        EmployeeView employeeView;
        LoginController loginController;
        Employee employee;
        bool update;
        public AddUpdateEmployeeView(bool isUpdate, Employee employeeSelected, EmployeeView parent)
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            loginController = new LoginController();
            employee = employeeSelected;
            this.employeeView = parent;
            this.employeeView.Enabled = false;
            update = isUpdate;
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            this.genderTableAdapter.Fill(this.rentMeDataSet.Gender);
            this.loginTableAdapter.Fill(this.rentMeDataSet.Login);
            ChangeEnabled(true);
            if (update)
            {
                this.Text = "Update Employee";
                lblEmployee.Text = "Update Employee Information";
                btnChangePassword.Visible = true;
                DisplayEmployee(employee);
                txtPassword.Enabled = false;
            }
            else
            {
                this.Text = "Add Employee";
                lblEmployee.Text = "Add Employee";
                cboState.SelectedIndex = -1;
                cboGender.SelectedIndex = -1;
                cboAdmin.SelectedIndex = -1;
                btnChangePassword.Visible = false;
            }

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
            cboAdmin.SelectedItem = employee.admin.ToString();
            txtUserID.Text = employee.login.ToString();
        }

        private void PutEmployee(Employee employee)
        {
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
            mtxtZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtFname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }
            else if (txtLname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a last name.");
                return;
            }

            else if (txtAddress1.Text == string.Empty)
            {
                MessageBox.Show("Please enter an address.");
                return;
            }

            else if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("Please enter a city.");
                return;
            }

            else if (mtxtZip.Text == string.Empty)
            {
                MessageBox.Show("Please enter a zip code.");
                return;
            }

            else if (mtxtHomePhone.Text == string.Empty)
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            else if (cboState.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a state.");
                return;
            }

            else if (cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            else if (cboAdmin.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            else
            {
                AddUpdateEmployee();
            }
            
        }

        private void AddUpdateEmployeeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtxtZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtFname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a first name.");
                    return;
                }
                else if (txtLname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a last name.");
                    return;
                }

                else if (txtAddress1.Text == string.Empty)
                {
                    MessageBox.Show("Please enter an address.");
                    return;
                }

                else if (txtCity.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a city.");
                    return;
                }

                else if (mtxtZip.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a zip code.");
                    return;
                }

                else if (mtxtHomePhone.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a phone number.");
                    return;
                }

                else if (cboState.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a state.");
                    return;
                }

                else if (cboGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                else if (cboAdmin.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                else
                {
                     AddUpdateEmployee();
                }
               
            }
        }

        private void ChangePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ChangePassword();
            }
        }

        private void AddUpdateEmployee()
        {
            Employee newEmployee = new Employee();

            try
            {
                if (!update)
                {
                    this.PutEmployee(newEmployee);
                    int employeeID = this.employeeController.AddEmployee(newEmployee);
                    employee = newEmployee;
                    employee.employeeID = employeeID;
                    if (!txtPassword.Text.Equals(""))
                    {
                        ChangePassword();
                    }
                    MessageBox.Show("Employee successfully added");
                    ChangeEnabled(true);
                    btnSubmit.Text = "Update Employee";
                    btnChangePassword.Visible = true;
                    btnChangePassword.Enabled = true;
                    txtPassword.Text = "";
                    txtPassword.Enabled = false;
                    lblEmployee.Text = "Update Employee Information";
                    this.Text = "Update Employee";
                }

                else if (update)
                {
                    this.PutEmployee(newEmployee);
                    newEmployee.employeeID = employee.employeeID;
                    if (!employeeController.UpdateEmployee(employee, newEmployee))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that employee.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Employee " + newEmployee.fname + " " + newEmployee.lname + " updated.");

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
            ChangePassword();
        }

        private void ChangePassword()
        {
            if (btnChangePassword.Text == "Change Password" && btnChangePassword.Visible)
            {
                btnSubmit.Enabled = false;
                btnChangePassword.Text = "Update Password";
                ChangeEnabled(false);
                btnExit.Enabled = true;
                btnChangePassword.Enabled = true;
                txtPassword.Enabled = true;
            }
            else if (btnChangePassword.Text == "Update Password" || (btnChangePassword.Text == "Change Password" && !btnChangePassword.Visible))
            {
                string password = loginController.EncryptPassword(txtPassword.Text);
                try
                {
                    if (employeeController.UpdateEmployeePassword(employee, password))
                    {
                        if (btnChangePassword.Text == "Update Password")
                        {
                            MessageBox.Show("Employee " + employee.fname + " " + employee.lname + " password updated.");
                            btnChangePassword.Text = "Change Password";
                        }
                        else
                        {
                            btnChangePassword.Text = "Update Password";
                        }
                        ChangeEnabled(true);
                        txtPassword.Text = "";
                        txtPassword.Enabled = false;
                    }
                    else
                    {
                        if (btnChangePassword.Text == "Update Password")
                        {
                            MessageBox.Show("Employee " + employee.fname + " " + employee.lname + " password not updated.");
                            btnChangePassword.Text = "Change Password";
                        }
                        else
                        {
                            btnChangePassword.Text = "Update Password";
                        }
                        ChangeEnabled(true);
                        txtPassword.Text = "";
                        txtPassword.Enabled = false;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    btnChangePassword.Text = "Change Password";
                    ChangeEnabled(true);
                    txtPassword.Text = "";
                    txtPassword.Enabled = false;
                }
            }
        }
        void ChangeEnabled(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
                if (c is Label)
                {
                    ((Label)c).Enabled = true;
                }
            }
        }


        private void AddUpdateEmployeeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            employee.fname = txtFname.Text;
            employee.lname = txtLname.Text;
            this.employeeView.refresh(employee.fname, employee.lname);
        }
    }
}
